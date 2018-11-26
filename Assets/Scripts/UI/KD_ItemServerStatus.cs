using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class KD_ItemServerStatus : MonoBehaviour
{
    public UILabel serverName = null;
    public UILabel serverPing = null;

    public List<GameObject> back = null;

    private const float intervalTime = 3f;

    private string ipAddress = null;
    private const int port = 6020;

    private System.Action update = null;

    private float lastUpdateTime = 0f;

    private void FixedUpdate()
    {
        if (Time.unscaledTime - lastUpdateTime > intervalTime)
        {
            lastUpdateTime = Time.unscaledTime;
            update();
        }
    }

    private void UpdateData()
    {
        DateTime startTime = System.DateTime.Now;

        if (PortCheck())
        {
            TimeSpan timeSpan = new TimeSpan(System.DateTime.Now.Ticks - startTime.Ticks);
            float elapsedTime = (float)timeSpan.TotalMilliseconds;
            float quality = PingQuality(elapsedTime);
            Color color = new Color(quality, 1 - quality, 0);
            serverPing.color = color;
            serverPing.text = elapsedTime.ToString("N3");
        }
        else
        {
            serverPing.color = Color.red;
            serverPing.text = "TimeOut";
        }

    }

    private void UpdateEmpty()
    {
        return;
    }

    private bool PortCheck()
    {
        Socket socket = null;
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, false);

        System.IAsyncResult asyncResult = socket.BeginConnect(ipAddress, port, null, null);

        return asyncResult.AsyncWaitHandle.WaitOne(300, true);
    }

    private float PingQuality(float elapsedTime)
    {
        float quality = elapsedTime / 300f;
        //Debug.Log("quality : " + quality);
        quality = Mathf.Clamp01(quality);
        return quality;
    }

    public void SetData(int i)
    {
        //serverName.text = KD_Define.serverName[i];
        serverName.text = KD_TextContainer.GetKey(i);
        ipAddress = KD_TextContainer.GetValue(i);
        back[i % 2].SetActive(true);
        update = UpdateData;
    }


}
