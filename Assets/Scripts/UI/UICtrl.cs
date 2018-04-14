using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI模块接受消息并通过
/// 事件码执行特定操作
/// </summary>
public class UICtrl : UIBase
{
    //声明菜单Index
    private enum MenuIndex
    {
        rootMenu = 0,
        startMenu = 1,
        achievementMenu = 2,
        shopMenu = 3,
        optionMenu = 4,
        aboutMenu = 5,
        loadingMenu = 6
    }

    [SerializeField]
    private GameObject[] _menuList;

    [SerializeField]
    private GameObject _buttonReturn;

    private void Awake()
    {
        Bind(UIEvent.UI_START_BUTTON_CLICK);

        ReturnMenu();
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

    /// <summary>
    /// 设置哪一个菜单显示
    /// </summary>
    /// <param name="n"></param>
    private void ShowMenu(int n)
    {
        for (int i = 0; i < _menuList.Length; i++)
        {
            if (i != n)
            {
                _menuList[i].SetActive(false);
            }
            else
            {
                _menuList[i].SetActive(true);
            }
        }
    }

    /// <summary>
    /// 点击开始按钮
    /// </summary>
    public void OnButtonClick(int menuIndex)
    {
        ShowMenu(menuIndex);
        _buttonReturn.SetActive(true);
        Dispatch(ModuleCode.MODUEL_AUDIO, AudioEvent.AUDIO_PLAY, null);
    }

    /// <summary>
    /// 返回菜单
    /// </summary>
    public void ReturnMenu()
    {
        ShowMenu((int)MenuIndex.rootMenu);
        _buttonReturn.SetActive(false);
    }

    /// <summary>
    /// 游戏开始
    /// </summary>
    public void GameBegin()
    {
        ShowMenu((int)MenuIndex.loadingMenu);
        LevelLoader.Instance.LoadLevel(1);
    }
}