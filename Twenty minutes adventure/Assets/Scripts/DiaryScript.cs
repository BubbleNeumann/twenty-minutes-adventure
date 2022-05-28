using System.Collections;
using System.Collections.Generic;
 using UnityEngine;
using UnityEngine.UI;

public class DiaryScript : MonoBehaviour
{
    [SerializeField] private GameObject DiaryCanvas;
    public static bool diaryIsOpen = false;
    // Start is called before the first frame update
    // void Start()
    // {
    //     DiaryCanvas.SetActive(false);
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            DiaryCanvas.SetActive(true);
            // DiaryCanvas.transform.SetActive(true);
            // diaryIsOpen = !diaryIsOpen;
            // Debug.Log("here we go");
        }
    }
}
