using System.Collections;
using System.Collections.Generic;
 using UnityEngine;
using UnityEngine.UI;

public class DiaryScript : MonoBehaviour
{
    [SerializeField] private GameObject DiaryCanvas;
    public static bool diaryIsOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            diaryIsOpen = !diaryIsOpen;
            DiaryCanvas.SetActive(diaryIsOpen);
        }
    }
}
