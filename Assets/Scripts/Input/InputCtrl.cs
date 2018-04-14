using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 声音模块接受消息并通过
/// 事件码执行特定操作
/// </summary>
public class InputCtrl : InputBase
{
    private void Awake()
    {

    }

    public override void Excute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case InputEvent.INPUT_UPDATE_MOVING_VECTOR:
                break;
            default:
                break;
        }
    }
}