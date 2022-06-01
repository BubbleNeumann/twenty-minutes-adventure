using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;

public class npc_cabinet : MonoBehaviour
{
    public GameObject npc_thief;
    // Start is called before the first frame update
    void Start()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("thief_catched")).value)
        {
            npc_thief.SetActive(true);
        }
        else
        {
            npc_thief.SetActive(false);
        }
    }
}
