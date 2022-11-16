using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenshot : MonoBehaviour
{
    private int imageNumber=0;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ScreenCapture.CaptureScreenshot($"screenshot{imageNumber}.png");
            imageNumber++;      
        }
    }
}
