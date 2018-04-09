using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 音频管理类单例
/// </summary>
public class GameManager : ManagerBase
{

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}
