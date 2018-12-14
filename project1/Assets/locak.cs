using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locak : MonoBehaviour {

    bool isPaused = false;

    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnApplicationFocus(bool ApplicationIsBack)
    {
        if (ApplicationIsBack == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }
    }
}