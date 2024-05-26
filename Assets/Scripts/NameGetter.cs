using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

  
public class NameGetter : MonoBehaviour
{
    public TMP_Text nameDisplay;

    public void GetName(string input)
    {
        DataSaver.Instance.playerName = input;
        DisplayName();
    }
   void DisplayName()
    {
        nameDisplay.text = "Playing As: " + DataSaver.Instance.playerName;
    }
    void Awake()
    {
        DisplayName();
    }
}
