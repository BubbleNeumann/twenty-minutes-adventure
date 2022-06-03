using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;
using Ink.Runtime;


namespace DialogTrigger
{
    public class DialogTrigger : MonoBehaviour
    {
        private bool playerInRange = false;

        [SerializeField] private bool objectIsTrigger;
        [Header("InkJSON")]
        [SerializeField] private TextAsset inkJSON;

        public void StartConversation() // начало диалога.
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                DialogManager.GetInstance().EnterDialogMode(inkJSON);
            }
        }

        public void Update()
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("donuts_chosen")).value || ((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("case_closed")).value)
            {
                SceneManager.LoadScene("credits");
            }
        }
        // переходы на различные локации.
        public void ToCrimeScene()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive() && !((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value) {
                SceneManager.LoadScene("CrimeScene");
            }
        }

        public void toSecondLoc()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive() && ((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
            {
                SceneManager.LoadScene("SecondLocation");
                PlayerPrefs.SetString("current_scene", "SecondLocation");
            }
        }

        public void RightDoor()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                SceneManager.LoadScene("cabinet");
                PlayerPrefs.SetString("current_scene", "cabinet");
            }
        }

        public void ToPoliceStation()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                SceneManager.LoadScene("police station");
                PlayerPrefs.SetString("current_scene", "police station");
            }
        }

        public void myCar2()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive() && ((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
            {
                SceneManager.LoadScene("police station");
                PlayerPrefs.SetString("current_scene", "police station");
            }
        }

        public void myCar()
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("call_accepted")).value)
            {
                SceneManager.LoadScene("SecondLocation");
                PlayerPrefs.SetString("current_scene", "SecondLocation");
            }
            else
            {
                DialogManager.GetInstance().EnterDialogMode(inkJSON);
            }
        }

        // убеждаемся, что игрок находится близко к интерактивному объекту.
        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                playerInRange = true;
                if (objectIsTrigger)
                {
                    StartConversation();
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                playerInRange = false;
            }
        }
    }
}

