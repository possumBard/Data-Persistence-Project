using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;                                    // Don't forget the TMPro

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI userName;            // Drag "Welcome" text in the Inspector (not required)
    public TMP_InputField userInputField;       // Drag the Input Text Box in the Inpector


    // Loads the Main scene when the Start button is pressed
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }


    public void InputPlayerName()
    {
        userName.text = "Welcome, " + userInputField.text;


        DataManager.Instance.playerName = userInputField.text;          // Saving tehe user input in the static class
        
        Debug.Log($"{ DataManager.Instance.playerName}");               // Print the user name in the console
    }

    
}
