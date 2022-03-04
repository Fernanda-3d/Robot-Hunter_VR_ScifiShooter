using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandAnimationController : MonoBehaviour
{
    public InputDeviceCharacteristics controllerType;
    public InputDevice thisController;

    private bool isControllerDetected = false;

    private Animator animatorController;

    void Start()
    {
        Initialise();
        animatorController = GetComponent<Animator>();
    }

    void Initialise()
    {
        //store the controller to the device to be find - using List<>
        List<InputDevice> controllerDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerType, controllerDevices);

        // search for all the input devices with the characteristics that we specified
        // in our public variable and store them in the list we just created

        // now this game object is going to be detecting input from the controller that we found
        // here and stored in the list
        if (controllerDevices.Count.Equals(0))
        {
            //Debug.Log("List is empty");
        }
        else
        {
            thisController = controllerDevices[0];
           // Debug.Log(thisController.name);
            isControllerDetected = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isControllerDetected)
        {
            Initialise();
        }
        else
        {
            //we need to detect when a button is pressed (trigger) and if the value is higher than 0.1
            //otherwise will be detecting even when is not being pressed
            if (thisController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
            {
               // Debug.Log("Trigger Press");
                //acess the animator component - control a value - trigger animation
                animatorController.SetFloat("Trigger", triggerValue);
                                
            }

            //them do the same thing for the (grip)
            if (thisController.TryGetFeatureValue(CommonUsages.grip, out float gripValue) && gripValue > 0.1f)
            {
                //Debug.Log("Grip Press" + gripValue);
                //acess the animator component - control a value - grip animation
                animatorController.SetFloat("Grip", gripValue);
            }
        }
       
    }
}
