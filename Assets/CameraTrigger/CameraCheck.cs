using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheck : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;
    private bool changeScene;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    void Start()
    {
        firstCamera.enabled = true;
        secondCamera.enabled = false;
        changeScene = false;
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    void Update()
    {
        if (changeScene = false)
        {
            firstCamera.enabled = true;
            secondCamera.enabled = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                firstCamera.enabled = false;
                secondCamera.enabled = true;
            }
        }
    }
}