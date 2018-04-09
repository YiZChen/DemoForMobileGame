using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 成就管理类单例
/// </summary>
public class AchievementManager : ManagerBase {

    private static AchievementManager _instance;
    public static AchievementManager Instance
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
