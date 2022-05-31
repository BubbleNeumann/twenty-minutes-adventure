using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;

public class npc_second : MonoBehaviour
{
    public GameObject oldwoman;
    public GameObject partner_sitting;
    public GameObject partner_standing;
    void Start()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
        {
            oldwoman.SetActive(true);
        }
        else
        {
            oldwoman.SetActive(false);
        }
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
        {
            partner_sitting.SetActive(false);
            partner_standing.SetActive(true);
        }
        else
        {
            partner_sitting.SetActive(true);
            partner_standing.SetActive(false);
        }
    }
}
