using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameButton : MonoBehaviour
{
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Changing Gun"))
        {
            //ChangeGun();
            
        }
    }

   
}
