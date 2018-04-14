using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 声音模块接受消息并通过
/// 事件码执行特定操作
/// </summary>
public class AudioCtrl : AudioBase
{
    private void Awake()
    {
        Bind(AudioEvent.AUDIO_PLAY);
    }

    public override void Excute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case AudioEvent.AUDIO_PLAY:
                Debug.Log("播放声音");
                break;

            case AudioEvent.AUDIO_VOLUME_CHANGE:
                break;
            default:
                break;
        }
    }
}
