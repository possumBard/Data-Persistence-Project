using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Allows access to this code in every other script
    public static DataManager Instance;

    public string playerName;



    private void Awake()
    {
        //if (Instance != null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // end of new code

}
