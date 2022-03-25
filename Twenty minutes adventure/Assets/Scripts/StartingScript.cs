using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingScript : MonoBehaviour
{
    public Text firstText;
    public Text secondText;
    public Canvas c;
    int n = 0;
    void Update()
    {
        if (n != 2)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (n == 0)
                {
                    secondText.gameObject.SetActive(true);
                }
                else
                {
                    c.gameObject.SetActive(false);
                }
                n++;
            }
        }
    }
}
