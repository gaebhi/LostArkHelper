using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_GM : MonoBehaviour
{
    static KD_GM Instance = null;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private IEnumerator Start()
    {
        yield return StartCoroutine(KD_TableLoader.LoadData(KD_Define.SERVERLIST));
        yield return null;
        KD_PNServerStatus.Instance.Show();
        yield break;
    }

    static public T FindObject<T>()
    {
        T findObject = Instance.GetComponentInChildren<T>(true);
        if (findObject == null)
            return KD_Root.FindObject<T>();
        return findObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (KD_UIStack.Escape() == false)
            {
                Debug.Log("No Popup!");
            }
        } 
    }
}
