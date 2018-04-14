using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 逻辑模块接受消息并通过
/// 事件码执行特定操作
/// </summary>
public class GameCtrl : GameBase
{
    private void Awake()
    {

    }

    public override void Excute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case GameEvent.GAME_LEVEL_CHOOSE:
                break;

            case GameEvent.GAME_LEVEL_BEGIN:
                break;

            case GameEvent.GAME_PAUSE:
                break;

            case GameEvent.GAME_OVER:
                break;

            default:
                break;
        }
    }
}