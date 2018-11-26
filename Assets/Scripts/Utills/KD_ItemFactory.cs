using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_ItemFactory : MonoBehaviour
{
    static KD_ItemFactory _instance = null;

    static public KD_ItemFactory Instance
    {
        get
        {
            if (_instance == null)
                _instance = KD_GM.FindObject<KD_ItemFactory>();
            return _instance;
        }
    }

    private void OnDestroy()
    {
        _instance = null;
    }

    static public T CreateItem<T>(T item,Transform parent) where T : MonoBehaviour
    {
        GameObject temp = Instantiate(item.gameObject, parent.transform, false) as GameObject;
        temp.transform.localPosition = Vector3.zero;
        temp.transform.localRotation = Quaternion.identity;
        temp.transform.localScale = Vector3.one;
        return temp.GetComponent<T>();
    }
}
