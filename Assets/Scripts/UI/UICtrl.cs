using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI模块接受消息并通过
/// 事件码执行特定操作
/// </summary>
public class UICtrl : UIBase
{
    private void Awake()
    {
        Bind(UIEvent.UI_START_BUTTON_CLICK);
    }

    public override void Excute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case UIEvent.UI_START_BUTTON_CLICK:
                Debug.Log("开始按钮被按下，进入二级菜单");
                break;

            case UIEvent.UI_ACHIEVEMENT_BUTTON_CLICK:
                break;

            case UIEvent.UI_SHOP_BUTTON_CLICK:
                break;

            case UIEvent.UI_OPTION_BUTTON_CLICK:
                break;

            case UIEvent.UI_ABOUT_BUTTON_CLICK:
                break;

            default:
                break;
        }
    }

    public void OnStartButtonClick()
    {
        Dispatch(ModuleCode.MODUEL_UI, UIEvent.UI_START_BUTTON_CLICK, null);
        Dispatch(ModuleCode.MODUEL_AUDIO, AudioEvent.AUDIO_PLAY, null);
    }
}