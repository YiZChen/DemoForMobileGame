using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 成就模块接受消息并通过
/// 事件码执行特定操作
/// </summary>
public class AchievementCtrl : AchievementBase
{
    private void Awake()
    {

    }

    public override void Excute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case AchievementEvent.ACHIEVEMENT_UPDATE:
                break;

            default:
                break;
        }
    }
}