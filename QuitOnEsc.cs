using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnEsc : MonoBehaviour
{
    void Start()
        {
        }

    void Update()
        {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
            Application.Quit();
            }
        }
}
