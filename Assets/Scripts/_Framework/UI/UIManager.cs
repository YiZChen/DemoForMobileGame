using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI管理类单例
/// </summary>
public class UIManager : ManagerBase
{

    private static UIManager _instance;
    public static UIManager Instance
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
