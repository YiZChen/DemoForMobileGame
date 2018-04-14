//游戏事件码定义规则
//0-20 模块码 | 21-30 成就码 | 31-40 声音码 | 41-50 商店码
//| 51-80 游戏逻辑码 | 81-90 输入码 | 90-150 UI码
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent
{
    #region Game事件集合
    public const int GAME_LEVEL_CHOOSE = 51;
    public const int GAME_LEVEL_BEGIN = 52;
    public const int GAME_PAUSE = 53;
    public const int GAME_OVER = 54;
    #endregion
}
