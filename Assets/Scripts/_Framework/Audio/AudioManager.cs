using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 音频管理类单例
/// </summary>
public class AudioManager : ManagerBase
{

    private static AudioManager _instance;
    public static AudioManager Instance
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
