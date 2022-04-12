using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogManager;
using UnityEngine.SceneManagement;

public class DialogTrigger : MonoBehaviour
{
    private bool playerInRange;

    [Header("InkJSON")]
    [SerializeField] private TextAsset inkJSON;

    private void Awake()
    {
        playerInRange = false;
    }

    public void StartConversation()
    {
        if (playerInRange)
        {
            DialogManager.GetInstance().EnterDialogMode(inkJSON);
        }
    }

    public void ToSecondLocation()
    {
        if(playerInRange)
        {
            DialogManager.GetInstance().EnterDialogMode(inkJSON);
            SceneManager.LoadScene("SecondLocation");
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
