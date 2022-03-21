using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer Am;
    Resolution[] rsl;
    public Dropdown dropdown;
    bool isFullScreen = true;

    public void Start()
    {
        rsl = Screen.resolutions;
    }

    public void ChangeFullScreen()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public void Resolution(int r)
    {
        //Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
    }

    public void BackToMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AudioVolume(float sliderValue)
    {
        Am.SetFloat("masterVol", sliderValue);
    }
}
