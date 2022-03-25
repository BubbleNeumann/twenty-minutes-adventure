using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogWindowScript : MonoBehaviour
{
    public Canvas dialog;
    public void onTriggerClicked()
    {
        dialog.gameObject.SetActive(true);
    }
}
