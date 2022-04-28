using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;
using Ink.Runtime;

namespace DialogTrigger {
    public class DialogTrigger : MonoBehaviour
    {
        private bool playerInRange;

        [SerializeField] private bool objectIsTrigger;

        [Header("InkJSON")]
        [SerializeField] private TextAsset inkJSON;

        private void Awake()
        {
            playerInRange = false;
        }

        public void StartConversation()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                DialogManager.GetInstance().EnterDialogMode(inkJSON);
            }
        }

        public void Update()
        {
            //if (toSecondLoc && !DialogManager.getDialogWindowIsActive())
            //{
            //    SceneManager.LoadScene("SecondLocation");
            //}
        }

        public void myCar()
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("call_accepted")).value) {
                SceneManager.LoadScene("SecondLocation");
            }
            else
            {
                DialogManager.GetInstance().EnterDialogMode(inkJSON);
            }
        }

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

