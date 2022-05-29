using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;

public class npc_thief : MonoBehaviour
{
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        npc.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_catched")).value)
        {
            npc.SetActive(false);
        }
    }

    public void toPoliceStation()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_catched")).value)
        {
            SceneManager.LoadScene("police station");
            PlayerPrefs.SetString("current_scene", "police station");
        }
    }
}
