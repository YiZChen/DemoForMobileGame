using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgCenter : MonoBase {

    private static MsgCenter _instance;
    public static MsgCenter Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;

        gameObject.AddComponent<AchievementManager>();
        gameObject.AddComponent<AudioManager>();
        gameObject.AddComponent<GameManager>();
        gameObject.AddComponent<UIManager>();
        gameObject.AddComponent<InputManager>();
        gameObject.AddComponent<ShopManager>();
    }

    /// <summary>
    /// 将事件发送至各个模块，让各个模块执行相应的事件码
    /// </summary>
    /// <param name="moduleCode">模块码</param>
    /// <param name="eventCode">事件码</param>
    /// <param name="message">传送事件的信息</param>
    public void Dispatch(int moduleCode, int eventCode, object message)
    {
        switch (moduleCode)
        {
            case ModuleCode.MODUEL_ACHIEVEMENT:
                AchievementManager.Instance.Excute(eventCode, message);
                break;

            case ModuleCode.MODUEL_AUDIO:
                AudioManager.Instance.Excute(eventCode, message);
                break;

            case ModuleCode.MODUEL_GAME:
                GameManager.Instance.Excute(eventCode, message);
                break;

            case ModuleCode.MODUEL_INPUT:
                InputManager.Instance.Excute(eventCode, message);
                break;

            case ModuleCode.MODUEL_SHOP:
                ShopManager.Instance.Excute(eventCode, message);
                break;

            case ModuleCode.MODUEL_UI:
                UIManager.Instance.Excute(eventCode, message);
                break;

            default:
                break;
        }
    }
}
