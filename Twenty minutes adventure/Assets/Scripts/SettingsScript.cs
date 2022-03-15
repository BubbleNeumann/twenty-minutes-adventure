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
    List<string> resolutions;
    public Dropdown dropdown;
    bool isFullScreen = true;

    public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }

    public void Resolution(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
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
