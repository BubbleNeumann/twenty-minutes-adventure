using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;

public class npc_police : MonoBehaviour
{
    public GameObject npc_criminalist;
    public GameObject npc_partner;
    // Start is called before the first frame update
    void Start()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("chief_visited")).value)
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_catched")).value)
            {
                if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_was_interrogated")).value)
                {
                    npc_partner.SetActive(true);
                    npc_criminalist.SetActive(true);
                }
                else
                {
                    npc_partner.SetActive(false);
                    npc_criminalist.SetActive(false);
                }
            }
            else
            {
                npc_partner.SetActive(false);
                npc_criminalist.SetActive(true);
            }
        }
        else
        {
            npc_partner.SetActive(false);
            npc_criminalist.SetActive(false);
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
