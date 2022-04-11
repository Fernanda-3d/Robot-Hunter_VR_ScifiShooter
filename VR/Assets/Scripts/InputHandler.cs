using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField nameInput;
    [SerializeField] string filename;
    

    List<HighscoreElements> entries = new List<HighscoreElements>();

    public void AddNameToList()
    {
        entries.Add(new HighscoreElements(nameInput.text, 0));
        nameInput.text = "";

        FileHandler.SaveToJSON<HighscoreElements>(entries, filename);
    }
}
