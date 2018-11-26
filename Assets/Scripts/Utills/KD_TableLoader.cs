using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class KD_TableLoader : MonoBehaviour
{
    static public IEnumerator LoadData(string fileName)
    {
        string serverList = null;
        fileName = KD_Define.SERVERLIST;
        using (UnityWebRequest www = UnityWebRequest.Get(fileName))
        {

            www.Send();

            while (!www.isDone)
                yield return null;

            if (www.isNetworkError || www.responseCode != (long)System.Net.HttpStatusCode.OK)
                yield break;

            serverList = www.downloadHandler.text;
            Debug.Log(serverList);
        }
        ParseServerList(serverList);
    }

    static public void ParseServerList(string buffer)
    {
        string[] lines = buffer.Split('\n');
        foreach (string line in lines)
        {
            string[] record = line.Split(',');
            if (record[0].StartsWith("ServerName") || record.Length <= 1)
                continue;
            KD_TextContainer.Add(record[0], record[1]);
        }
        Debug.Log("Parse Done");
    }
}
