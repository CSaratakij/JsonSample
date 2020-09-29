using System;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public string UserID;
    public string Name;
    public Vector3 Position;

    public override string ToString()
    {
        var result = $"UserID : {UserID}, ";
        result += $"Position : x: {Position.x}, y: {Position.y}, z: {Position.z}";
        return result;
    }

    public string ToStringDirectCall()
    {
        var result = $"UserID : {UserID}, ";
        result += $"Position : {Position}";
        return result;
    }
}

