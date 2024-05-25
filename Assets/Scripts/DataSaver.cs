using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaver : MonoBehaviour
{
  
  public static DataSaver Instance;
  [SerializeField] public string playerName;
    public int highscore;

    private void Awake()
    {
       
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }
    
}
