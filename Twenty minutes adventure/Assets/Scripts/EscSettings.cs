using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscSettings : MonoBehaviour
{
    public Canvas menuCanvas;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //menuCanvas.enabled = !menuCanvas.enabled;
            SceneManager.LoadScene("Menu");
        }
    }

    public void MenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SettingsPressed()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
