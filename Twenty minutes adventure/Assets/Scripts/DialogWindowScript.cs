using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogWindowScript : MonoBehaviour
{
    public Canvas dialog;
    public Text dialogName;
    public Text dialogText;
    bool dialogShown = false;

    public void onTriggerClicked()
    {
        dialog.gameObject.SetActive(true);
        dialogShown = true;
        dialogName.text = "Я:";
        dialogText.text = "это мой автомобиль. но я хочу прогуляться пешком.";
    }

    public void Update()
    {
        if (dialogShown)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                dialog.gameObject.SetActive(false);
                dialogShown = false;
            }
        }
    }
}
