using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_Root : MonoBehaviour
{
    static public T FindObject<T>()
    {
        KD_Root findRoot = FindObjectOfType<KD_Root>();
        if (findRoot != null)
            return findRoot.gameObject.GetComponentInChildren<T>(true);
        else
            return default(T);//value type인 경우는 0, reference type인 경우에는 null
    }

}
