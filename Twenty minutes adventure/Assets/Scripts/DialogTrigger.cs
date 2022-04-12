using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogManager;

public class DialogTrigger : MonoBehaviour
{
    private bool playerInRange;

    [Header("InkJSON")]
    [SerializeField] private GameObject inkJSON;

    private void Awake()
    {
        playerInRange = false;
    }

    private void Update()
    {
        if (playerInRange)
        {
            //if (InputManager.GetInstance.GetInteractPressed())
            //{
            //    DialogManager.GetInstance().EnterDialogMode(inkJSON);
            //}
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
