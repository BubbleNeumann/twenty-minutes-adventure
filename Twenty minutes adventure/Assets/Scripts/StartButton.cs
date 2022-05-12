using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void SettingsPressed()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void PlayPressed()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("StartingLocation");
    }

    public void LoadPressed()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("current_scene", "Menu"));
    }
}
