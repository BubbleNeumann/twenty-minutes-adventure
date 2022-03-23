using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscSettings : MonoBehaviour
{
    public Canvas c;
    bool menuOpen = false;
    public void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Escape.ToString())))
        {
            Debug.Log("ESC");
            menuOpen = !menuOpen;
            c.gameObject.SetActive(menuOpen);
        }
    }

    public void MenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SettingsPressed()
    {
        SceneManager.LoadScene("SettigsScene");
    }


}
