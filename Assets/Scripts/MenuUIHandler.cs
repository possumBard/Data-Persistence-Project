using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TMP_InputField userInputField;


    // Loads the Main scene when the Start button is pressed
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }


    public void InputPlayerName()
    {
        userName.text = "Welcome, " + userInputField.text;


        DataManager.Instance.playerName = userInputField.text;
        
        Debug.Log($"{ DataManager.Instance.playerName}");
    }

    
}
