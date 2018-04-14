using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 所有Manager类的基类，包含消息的执行
/// 模块添加消息监听
/// </summary>
public class ManagerBase : MonoBase {

    //利用字典数据结构储存事件码和关心该事件的模块
    private Dictionary<int, List<MonoBase>> dic = new Dictionary<int, List<MonoBase>>();

    /// <summary>
    /// 对MonoBase中的执行方法进行重写，
    /// Manager类将继承该类，并执行各自独特的事件码
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="message"></param>
    public override void Excute(int eventCode, object message)
    {
        //判断字典中是否含有该事件码
        if (!dic.ContainsKey(eventCode))
        {
            Debug.LogWarning(eventCode + "号事件没有被注册");
            return;
        }

        // 向将监听该事件的模块传递消息并执行
        List<MonoBase> moduleList = dic[eventCode];
        for (int i = 0; i < moduleList.Count; i++)
        {
            moduleList[i].Excute(eventCode, message);
        }
    }

    /// <summary>
    /// 注册一个事件，将事件码放入字典当中，并增添监听
    /// 该事件的模块集合
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="mono"></param>
    public void Add(int eventCode, MonoBase mono)
    {
        List<MonoBase> list = null;

        //之前未注册该事件
        if (!dic.ContainsKey(eventCode))
        {
            list = new List<MonoBase>();
            list.Add(mono);
            dic.Add(eventCode, list);
            return;
        }

        //事件已经被注册
        list = dic[eventCode];
        list.Add(mono);
    }

    /// <summary>
    /// 注册多个事件到字典当中
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="mono"></param>
    public void Add(int[] eventCode, MonoBase mono)
    {
        for (int i = 0; i < eventCode.Length; i++)
        {
            Add(eventCode[i], mono);
        }
    }

    /// <summary>
    /// 将事件从字典中删除
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="mono"></param>
    public void Remove(int eventCode, MonoBase mono)
    {
        //如果所指定的事件没有注册
        if (!dic.ContainsKey(eventCode))
        {
            Debug.LogWarning(eventCode + "号事件没有被注册");
            return;
        }

        List<MonoBase> list = dic[eventCode];

        if (list.Count == 1)
            dic.Remove(eventCode);
        else
            list.Remove(mono);
    }

    /// <summary>
    /// 移除一串事件
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="mono"></param>
    public void Remove(int[] eventCode, MonoBase mono)
    {
        for (int i = 0; i < eventCode.Length; i++)
        {
            Remove(eventCode[i], mono);
        }
    }
}
