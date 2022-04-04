using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypingArea : MonoBehaviour
{
    //public GameObject leftHand;
   // public GameObject rightHand;
    public GameObject leftTypingHand;
    public GameObject rightTypingHand;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LeftHand")
        {
            leftTypingHand.SetActive(true);
        } 
        else if (other.gameObject.tag == "RightHand")
        {
            rightTypingHand.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            leftTypingHand.SetActive(false);
        }
        else if (other.gameObject.tag == "RightHand")
        {
            rightTypingHand.SetActive(false);
        }

    }
}
