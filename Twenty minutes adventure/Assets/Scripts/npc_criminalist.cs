using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;

public class npc_criminalist : MonoBehaviour
{
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("chief_visited")).value)
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_catched")).value)
            {
                if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_was_interrogated")).value)
                {
                    npc.SetActive(true);
                }
                else
                {
                    npc.SetActive(false);
                }
            }
            else
            {
                npc.SetActive(true);
            }
        }
        else
        {
            npc.SetActive(false);
        }
    }

    public void toGasStation()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("criminalist_told")).value)
        {
            SceneManager.LoadScene("gas station");
            PlayerPrefs.SetString("current_scene", "gas station");
        }
    }
}
