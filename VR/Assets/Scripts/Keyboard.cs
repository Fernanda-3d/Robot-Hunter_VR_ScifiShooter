using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keyboard : MonoBehaviour
{
    public InputField inputField;
    private float delay;

    public string theName;
    public static string playerName;
       
    public GameObject normalButtons;
    public GameObject capsButtons;
    private bool caps;
        

    void Start()
    {
        caps = false;
        
    }

    public void InsertChar(string c)
    {
        inputField.text += c;
    }

    public void DeleteChar()
    {
        if(inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }

    public void InsertSpace()
    {
        inputField.text += " ";
    }

    public void CapsPressed()
    {
        if (!caps)
        {
            normalButtons.SetActive(false);
            capsButtons.SetActive(true);
            caps = true;
        }
        else
        {
            normalButtons.SetActive(true);
            capsButtons.SetActive(false);
            caps = false;
        }
        
    }

    public void SaveName()
    {

        theName = inputField.GetComponentInChildren<Text>().text;
        playerName = theName;
        PlayerPrefs.SetString("theName", playerName);

        StartCoroutine(WaitforSceneLoad());
        
                
    }

    IEnumerator WaitforSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("XR_FirstScene");
    }


}
