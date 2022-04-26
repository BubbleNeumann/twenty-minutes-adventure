using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;

public class DialogTrigger : MonoBehaviour
{
    private bool playerInRange;
    private bool toSecondLoc;

    [SerializeField] private bool objectIsTrigger;

    [Header("InkJSON")]
    [SerializeField] private TextAsset inkJSON;

    private void Awake()
    {
        playerInRange = false;
        toSecondLoc = false;
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
        if (toSecondLoc && !DialogManager.getDialogWindowIsActive())
        {
            SceneManager.LoadScene("SecondLocation");
        }
    }

    public void ToSecondLocation()
    {
        DialogManager.GetInstance().EnterDialogMode(inkJSON);
        toSecondLoc = true;
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
