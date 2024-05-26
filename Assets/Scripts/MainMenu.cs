using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitGame()
    {
        DataSaver.Instance.SaveHighScore();
        Application.Quit(); // original code to quit Unity player
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
