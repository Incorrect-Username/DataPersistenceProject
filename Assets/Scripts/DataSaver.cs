using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataSaver : MonoBehaviour
{
  
  public static DataSaver Instance;
  public string playerName;
  public string bestPlayerName;
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
        LoadHighScore();
        
    }
    [System.Serializable]
    class DataToSave
    {
        public string playerName;
        public string bestPlayerName;
        public int highscore;
    }
    public void SaveHighScore()
    {
        DataToSave data = new DataToSave();
        data.playerName = playerName;
        data.bestPlayerName = bestPlayerName;
        data.highscore = highscore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataToSave data = JsonUtility.FromJson<DataToSave>(json);
            playerName = data.playerName;
            bestPlayerName = data.bestPlayerName; 
            highscore = data.highscore;
        }
    }
}



