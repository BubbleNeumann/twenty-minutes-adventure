using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;

public class parner : MonoBehaviour
{
    public GameObject oldwoman;
    void Start()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
        {
            oldwoman.SetActive(false);
        }
        else
        {
            oldwoman.SetActive(true);
        }
    }
    void Update()
    {
        if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
        {
            oldwoman.SetActive(false);
        }
    }
}
