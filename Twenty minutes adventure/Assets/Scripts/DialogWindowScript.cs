using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogWindow
{
    public class DialogWindowScript : MonoBehaviour
    {
        public Canvas dialog;
        public Text dialogName;
        public Text dialogText;
        private static bool dialogWindowIsActive = false;

        public static bool getDialogWindowIsActive()
        {
            return dialogWindowIsActive;
        }

        public void onTriggerClicked()
        {
            dialog.gameObject.SetActive(true);
            dialogWindowIsActive = true;
            dialogName.text = "Вы:";
            dialogText.text = "Это мой автомобиль. Но я хочу прогуляться пешком.";
        }

        public void Update()
        {
            if (dialogWindowIsActive)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
                {
                    dialog.gameObject.SetActive(false);
                    dialogWindowIsActive = false;
                }
            }
        }
    }
}
