using System;
using UnityEngine;

public class Guns_Selection : MonoBehaviour
{
    /*Create a Weapon Selection with 1st button press by enabling and disabling the child objects*/

    //create a variable int to represent your gun with index selection
    public int selectedWeapon = 0;
   
    void Start()
    {
        SelectWeapon();
      //  PressButton();
        Debug.Log("Waiting for button press");
    }

    private void SelectWeapon()
    {
        int i = 0;
        /* loop through all of the weapons and if the selected weapon index does not match
         * with the weapon we're looping trhough, we will disable, and if does match we will enable*/
        foreach (Transform weapon in transform) // this means we will get all the transforms on the child and see if they match with the transform we have selected
        {
            if (i == selectedWeapon) /*we want to enable*/
            weapon.gameObject.SetActive(true);
            else /*if doesnt match*/
            weapon.gameObject.SetActive(false);

            i++;
        }
    }

    void Update()
    {
       // PressButton();
    }

    public void PressButton()
    {
         int previousSelectedWeapon = selectedWeapon;
        
        //Get input to change the weapon
        if (selectedWeapon >= transform.childCount - 1) 
            selectedWeapon = 0;
        else
            selectedWeapon++;

        if (selectedWeapon <= 0)
            selectedWeapon = transform.childCount - 1;
        else
            selectedWeapon--;

        if(previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        Debug.Log("pressed");
    }

    }


}


