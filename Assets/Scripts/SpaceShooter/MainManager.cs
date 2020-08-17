﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject LoadingUI;
    public GameObject SettingUI;

    public void OnClickStartButton()
    {
        SoundContoller.Instance.PlayStartSound.Play();
        LoadingUI.SetActive(true);
    }
    public void OnClickSettingButton()
    {
        SettingUI.SetActive(true);
    }
    public void OnCloseSettingWin()
    {
        SettingUI.SetActive(false);
    }




    public void OnClickButton()
    {
        SoundContoller.Instance.ButtonSound.Play();
        MainUI.SetActive(false);
    }
    public void OnCloseWin()
    {
        SoundContoller.Instance.ButtonSound.Play();
        MainUI.SetActive(true);
    }

    public void OnClickExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
