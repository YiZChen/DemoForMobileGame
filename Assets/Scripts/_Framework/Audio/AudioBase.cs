using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 声音类
/// </summary>
public class AudioBase : MonoBase
{

    List<int> list = new List<int>();

    /// <summary>
    /// 模块绑定一个或者多个事件
    /// </summary>
    /// <param name="eventCodes"></param>
    protected void Bind(params int[] eventCodes)
    {
        list.AddRange(eventCodes);
        AudioManager.Instance.Add(list.ToArray(), this);
    }

    /// <summary>
    /// 事件的解绑
    /// </summary>
    protected void UnBind()
    {
        AchievementManager.Instance.Remove(list.ToArray(), this);
    }

    /// <summary>
    /// 当脚本销毁时解除事件的绑定
    /// </summary>
    public virtual void OnDestroy()
    {
        if (list != null)
            UnBind();
    }

    /// <summary>
    /// 通过消息转发中心向各个模块发送数据
    /// </summary>
    /// <param name="moduleCode"></param>
    /// <param name="eventCode"></param>
    /// <param name="message"></param>
    public void Dispatch(int moduleCode, int eventCode, object message)
    {
        MsgCenter.Instance.Dispatch(moduleCode, eventCode, message);
    }
}
