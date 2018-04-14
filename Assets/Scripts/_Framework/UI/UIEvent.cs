//游戏事件码定义规则
//0-20 模块码 | 21-30 成就码 | 31-40 声音码 | 41-50 商店码
//| 51-80 游戏逻辑码 | 81-90 输入码 | 90-150 UI码
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEvent
{
    #region UI事件集合
    public const int UI_START_BUTTON_CLICK = 91;
    public const int UI_ACHIEVEMENT_BUTTON_CLICK = 92;
    public const int UI_SHOP_BUTTON_CLICK = 93;
    public const int UI_OPTION_BUTTON_CLICK = 94;
    public const int UI_ABOUT_BUTTON_CLICK = 95;

    public const int UI_BACK_BUTTON_CLICK = 96;
    #endregion

}
