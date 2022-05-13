using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;

public class Stepanida : MonoBehaviour
{
    public GameObject oldwoman;
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
    }
}
