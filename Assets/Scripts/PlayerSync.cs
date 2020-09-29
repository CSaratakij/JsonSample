using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSync : MonoBehaviour
{
    string json;
    PlayerData data;

    void Awake()
    {
        Initialize();
    }

    void Start()
    {
        SyncFromJSon();
    }

    void Initialize()
    {
        var data = new PlayerData();

        data.UserID = "weroiu32408324lkj";
        data.Name = "Player 1";
        data.Position = transform.position;

        json = JsonUtility.ToJson(data);

        Debug.Log("Initialize json string....");
        Debug.Log(json);

        Debug.Log("------------------------------");
    }

    void SyncFromJSon()
    {
        data = GetPlayerData(json);

        Debug.Log("Print from PlayerData -> override ToString....");
        Debug.Log(data);

        Debug.Log("------------------------------");

        Debug.Log("Print from Vector3 -> ToString call....");
        Debug.Log(data.ToStringDirectCall());
    }


    PlayerData GetPlayerData(string json)
    {
        var data = JsonUtility.FromJson<PlayerData>(json);
        return data;
    }
}

