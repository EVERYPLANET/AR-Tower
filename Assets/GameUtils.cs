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
