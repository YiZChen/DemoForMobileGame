using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 输入控制管理类单例
/// </summary>
public class ShopManager : ManagerBase
{

    private static ShopManager _instance;
    public static ShopManager Instance
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
