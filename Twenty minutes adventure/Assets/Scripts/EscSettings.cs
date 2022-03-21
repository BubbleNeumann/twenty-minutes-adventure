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
            if (menuOpen == false)
            {
                c.gameObject.SetActive(true);
                menuOpen = true;
            }
            else
            {
                c.gameObject.SetActive(false);
                menuOpen = false;
            }
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
