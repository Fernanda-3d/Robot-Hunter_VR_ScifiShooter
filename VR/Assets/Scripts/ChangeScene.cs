using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

   
    public void ChangingScene()
    {
        SceneManager.LoadScene("XR_SecondScene");
    }

    public void PressStart()
    {
        SceneManager.LoadScene("XR_KeyboardMenu");
    }

    public void SkipTutorial()
    {
        SceneManager.LoadScene("XR_SecondScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
