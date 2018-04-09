using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 输入控制管理类单例
/// </summary>
public class InputManager : ManagerBase
{

    private static InputManager _instance;
    public static InputManager Instance
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
