//游戏事件码定义规则
//0-20 模块码 | 21-30 成就码 | 31-40 声音码 | 41-50 商店码 | 51-80 UI码81-90 输入码

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏模块的独立编码，消息中心通过这些数字
/// 分别将不同的消息转发至相应的模块
/// </summary>
public class ModuleCode{

    public const int MODUEL_GAME = 0;
    public const int MODUEL_ACHIEVEMENT = 1;
    public const int MODUEL_AUDIO = 2;
    public const int MODUEL_SHOP = 3;
    public const int MODUEL_UI = 4;
    public const int MODUEL_INPUT = 5;
}