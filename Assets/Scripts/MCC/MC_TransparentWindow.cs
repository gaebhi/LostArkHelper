using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class MC_TransparentWindow : MonoBehaviour
{
	[SerializeField]
    private Material transparentMaterial;

    #region rect
    [StructLayout(LayoutKind.Sequential)]
    public class RECT
    {
        private int Left, Top, Right, Bottom;

        public RECT(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public RECT(System.Drawing.Rectangle r)
            : this(r.Left, r.Top, r.Right, r.Bottom)
        {
        }

        public int X
        {
            get
            {
                return Left;
            }
            set
            {
                Right -= (Left - value);
                Left = value;
            }
        }

        public int Y
        {
            get
            {
                return Top;
            }
            set
            {
                Bottom -= (Top - value);
                Top = value;
            }
        }

        public int Height
        {
            get
            {
                return Bottom - Top;
            }
            set
            {
                Bottom = value + Top;
            }
        }

        public int Width
        {
            get
            {
                return Right - Left;
            }
            set
            {
                Right = value + Left;
            }
        }

        public static implicit operator System.Drawing.Rectangle(RECT r)
        {
            return new System.Drawing.Rectangle(r.Left, r.Top, r.Width, r.Height);
        }

        public static implicit operator RECT(System.Drawing.Rectangle r)
        {
            return new RECT(r);
        }
    }
    #endregion

    private class MARGINS
    {
        public int cxLeftWidth;
        public int cxRightWidth;
        public int cyTopHeight;
        public int cyBottomHeight;
    }

    #region user32dll
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("Dwmapi.dll")]
    private static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);

    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern int SetWindowPos(IntPtr hwnd, int hwndInsertAfter, int x, int y, int cx, int cy, int uFlags);

    [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
    static extern int SetLayeredWindowAttributes(IntPtr hwnd, int crKey, byte bAlpha, int dwFlags);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

    const int GWL_STYLE = -16;
    const uint WS_POPUP = 0x80000000;
    const uint WS_VISIBLE = 0x10000000;
    const int HWND_TOPMOST = -1;

    #endregion

    private bool clickThrough = false;

    private IntPtr hwnd;

    void Start()
    {
#if !UNITY_EDITOR  

        var margins = new MARGINS() { cxLeftWidth = -1 };
        hwnd = GetActiveWindow();

        SetWindowLong(hwnd, GWL_STYLE, WS_POPUP | WS_VISIBLE);
        SetWindowPos(hwnd, HWND_TOPMOST, (Screen.currentResolution.width - MC_UIRoot.width) / 2, (Screen.currentResolution.height - MC_UIRoot.height) / 2, MC_UIRoot.width, MC_UIRoot.height, 32 | 64); //SWP_FRAMECHANGED = 0x0020 (32); //SWP_SHOWWINDOW = 0x0040 (64)
        DwmExtendFrameIntoClientArea(hwnd, ref margins);
#endif
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Z))
            clickThrough = !clickThrough;

        if (clickThrough)
        {
            SetWindowLong(hwnd, -20, (uint)524288 | (uint)32);//GWL_EXSTYLE=-20; WS_EX_LAYERED=524288=&h80000, WS_EX_TRANSPARENT=32=0x00000020L
            SetLayeredWindowAttributes(hwnd, 0, 255, 2);// Transparency=51=20%, LWA_ALPHA=2
            SetWindowPos(hwnd, HWND_TOPMOST, (Screen.currentResolution.width - MC_UIRoot.width) / 2, (Screen.currentResolution.height - MC_UIRoot.height) / 2, MC_UIRoot.width, MC_UIRoot.height, 32 | 64); //SWP_FRAMECHANGED = 0x0020 (32); //SWP_SHOWWINDOW = 0x0040 (64)
        }
        else
        {
            SetWindowLong(hwnd, -20, WS_POPUP | WS_VISIBLE);
            SetWindowPos(hwnd, HWND_TOPMOST, (Screen.currentResolution.width - MC_UIRoot.width) / 2, (Screen.currentResolution.height - MC_UIRoot.height) / 2, MC_UIRoot.width, MC_UIRoot.height, 32 | 64); //SWP_FRAMECHANGED = 0x0020 (32); //SWP_SHOWWINDOW = 0x0040 (64)
        }
    }

    void OnRenderImage(RenderTexture from, RenderTexture to)
    {
        Graphics.Blit(from, to, transparentMaterial);
    }
}