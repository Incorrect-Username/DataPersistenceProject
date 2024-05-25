using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

  
public class NameGetter : MonoBehaviour
{
    public void GetName(string input)
    {
        DataSaver.Instance.playerName = input;
    }

}
