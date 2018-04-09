using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 基于MonoBehaviour的拓展，增加虚函数Excute，供子类重写
/// 并独立于每一个模块执行自己的代码
/// </summary>
public class MonoBase : MonoBehaviour {

    public virtual void Excute(int eventCode, object message)
    {

    }
}
