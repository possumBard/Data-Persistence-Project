using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;                                // Data persistence between sessions

public class DataManager : MonoBehaviour
{
    // Allows access to this code in every other script (static class)
    public static DataManager Instance;

    public string playerName;                   // Data persistence between scenes

    public string winnerName;                   // Data persistence between sessions
    public int highScore;


    
    private void Awake()
    {
        //if (Instance != null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        // Data persistence between scenes
        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Data persistence between sessions
        LoadHighScore();
    }


    // Data persistence between sessions
    [System.Serializable]
    class SaveData
    {
        public string winnerName;
        public int highScore;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();                            // Created instance of SaveData()
        data.winnerName = winnerName;                              // Filled the SaveData() class with the respective variables from the game
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);                                         // Transformed SaveData() data to JSON

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);     // Wrote the data to a safe JSON file
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";                // Finds the saved JSON file

        if (File.Exists(path))                                                          // Checks if the JSON file exists
        {
            string json = File.ReadAllText(path);                                       // Reads the found JSON file
            SaveData data = JsonUtility.FromJson<SaveData>(json);                       // Transforms the JSON back to SaveData()

            winnerName = data.winnerName;                                               // Sets the saved data to the current high score
            highScore = data.highScore;
        }
    }
}
