using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Start()
    {
        Invoke("MyLoadingFunction", 10f);
    }
    void MyLoadingFunction()
    {
        SceneManager.LoadScene("Character_Test");
    }
}
