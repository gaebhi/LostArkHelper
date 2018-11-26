using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_UIStack
{
    static Stack<KD_Window> container = new Stack<KD_Window>();

    static public void Push(KD_Window window)
    {
        if (container.Contains(window) == false)
            container.Push(window);
        PushWindow(window);
    }

    static public bool Pop()
    {
        if (container.Count > 0)
        {
            KD_Window target = container.Pop();
            target.gameObject.SetActive(false);
            return true;
        }
        return false;
    }

    static void PushWindow(KD_Window window)
    {
        PopAll();
        container.Push(window);
        window.gameObject.SetActive(true);
    }

    static public KD_Window GetTop()
    {
        if (container.Count > 0)
            return container.Peek();
        else
            return null;
    }

    static public bool Escape()
    {
        if (container.Count > 0 && container.Peek() != null)
        {
            container.Peek().Escape();
            return true;
        }
        return false;
    }

    static public void Clear()
    {
        container.Clear();
    }

    static public void PopAll()
    {
        while (container.Count > 0 && container.Peek() != null)
            container.Peek().Hide();
    }
}
