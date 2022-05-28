using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryScript : MonoBehaviour
{
    [SerializeField] private GameObject DiaryCanvas;
    public static bool diaryIsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        DiaryCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            DiaryCanvas.SetActive(true);
            diaryIsOpen = !diaryIsOpen;
        }
    }
}
