using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns_Selection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Waiting for button press");
    }

    public void PressButton()
    {
        Debug.Log("Pressing 1st button");
    }

    // Update is called once per frame
    void Update()
    {
        PressButton();
    }
}
