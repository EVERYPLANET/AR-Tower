using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUtils : MonoBehaviour
{
    [SerializeField] private GameObject _consoleText;

    public void SendToConsole(string message)
    {
        _consoleText.GetComponent<TMP_Text>().text = message;
    }
}
