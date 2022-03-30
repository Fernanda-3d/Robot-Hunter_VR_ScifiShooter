using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guns_Selection : MonoBehaviour
{
    //get reference of the objects
    private GameObject[] gunList;
    
    private int index;

    public GameObject timeline;
   
    private void Start()
    {
        timeline.SetActive(false);

        //this is getting the gun index that was selected in the menu scene to load in the main scene
        index = PlayerPrefs.GetInt("GunSelected");

        //define the size of the list
        gunList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++) //use the index to get track of the transforms
        {
            gunList[i] = transform.GetChild(i).gameObject;  //this is used to fill up the array
        }

        //turn them off
        foreach (GameObject gunObj in gunList)
            gunObj.SetActive(false);

        //turn on the selected gun putting on index instead of number if index in the array
        if (gunList[index])                 //if we have the gun index 0 
            gunList[index].SetActive(true); //them turn on
             
    }

    public void PressLeft()
    {
        //turn off the model, change the index, turn on the new model for the new index

        // Toggle off the current model
        gunList[index].SetActive(false);

        index--; //the same as index  = index -1;
        if (index < 0) //if is less then 0
            index = gunList.Length - 1; //them bring me back to the end of the index and keep goind down - EX. the last index is 3 - so you do 0, 3, 2, 1, 0...

        //Toggle on the new moddel
        gunList[index].SetActive(true);

    }

    public void PressRight()
    {
        //turn off the model, change the index, turn on the new model for the new index

        // Toggle off the current model
        gunList[index].SetActive(false);

        index++; 
        if (index == gunList.Length) //if is less then 0
            index = 0; //them bring me back to the end of the index and keep goind down - EX. the last index is 3 - so you do 0, 3, 2, 1, 0...

        //Toggle on the new moddel
        gunList[index].SetActive(true);

    }

    public void ChangeScene()
    {
        PlayerPrefs.SetInt("GunSelected", index);

        timeline.SetActive(true);

    }

    public void ChangeToGame()
    {
        SceneManager.LoadScene("XR_Level1");
    }
     

}


