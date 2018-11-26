using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KD_TextContainer : MonoBehaviour
{
    static Dictionary<string, string> container = new Dictionary<string, string>();
    static string notFoundError = "[TextNotFound]";

    static public void Clear()
    {
        container.Clear();
        System.GC.Collect();
    }

    static public void Add(string id, string value)
    {
        if (container.ContainsKey(id))
            container[id] = value;
        else
            container.Add(id, value);

        Debug.Log(id + " " + value);
    }

    static public void Remove(string id)
    {
        if (container.ContainsKey(id))
            container.Remove(id);
    }

    static public string GetValueByKey(string id)
    {
        if (container.ContainsKey(id))
            return container[id];
        return notFoundError;
    }

    static public string GetValue(int index)
    {
        if (container.Count > index)
            return container.ElementAt(index).Value;
        return notFoundError;
    }

    static public string GetKey(int index)
    {
        if (container.Count > index)
            return container.ElementAt(index).Key;
        return notFoundError;
    }

    static public int GetLength()
    {
        return container.Count;
    }
}
