using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_PNServerStatus : KD_Window
{
    static KD_PNServerStatus _instance = null;

    public UICenterOnChild onCenterChild = null;
    public UIScrollView scrollView = null;
    public KD_ItemServerStatus item = null;
    public UIGrid grid = null;

    private List<KD_ItemServerStatus> itemList = null;

    static public KD_PNServerStatus Instance
    {
        get
        {
            if (_instance == null)
                _instance = KD_GM.FindObject<KD_PNServerStatus>();
            return _instance;
        }
    }

    private void Awake()
    {
        onCenterChild.onCenter = OnCenter;
        itemList = new List<KD_ItemServerStatus>();
    }
    public override void Show()
    {
        base.Show();
        Clear();
        SetList();
    }

    private void Clear()
    {
        foreach (var obj in itemList)
            obj.gameObject.SetActive(false);
        itemList.Clear();
    }

    private void SetList()
    {
        KD_ItemServerStatus temp = null;

        for (int i = 0; i < KD_TextContainer.GetLength(); i++)
        {
            if (i >= scrollView.transform.childCount)
                temp = KD_ItemFactory.CreateItem<KD_ItemServerStatus>(item, scrollView.transform);
            else
                temp = scrollView.transform.GetChild(i).GetComponent<KD_ItemServerStatus>();
            temp.gameObject.SetActive(true);
            itemList.Add(temp);
            temp.SetData(i);
        }
        scrollView.ResetPosition();
    }

    private void OnCenter(GameObject center)
    {

    }
    public void OnClikThis()
    {
        base.Hide();
    }
}
