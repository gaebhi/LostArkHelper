using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_Window : MonoBehaviour
{
    KD_Window tempWindow = null;

    public virtual void OnDestroy()
    {

    }

    public virtual void Show()
    {
        KD_UIStack.Push(this);
    }

    public virtual void Escape()
    {
        Hide();
    }

    public virtual void Hide()
    {
        tempWindow = KD_UIStack.GetTop();
        if (tempWindow != null && tempWindow == this)
            KD_UIStack.Pop();
    }
}
