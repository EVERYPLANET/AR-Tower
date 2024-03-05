using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] private string[] textStrings = new string[3];
    [SerializeField] private TextMeshProUGUI textBox;
    private int currentStringIndex = 0;

   
    void Start()
    {
        currentStringIndex = 0;
        textBox.text = textStrings[currentStringIndex]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextString()
    {
        if(currentStringIndex < textStrings.Length -1)
        {
            currentStringIndex++;
            textBox.text = textStrings[currentStringIndex];
        }
        else
        {
            currentStringIndex = 0;
            textBox.text = textStrings[currentStringIndex];
        }
    }

    private void OnDisable()
    {
        currentStringIndex = 0;
        textBox.text = textStrings[currentStringIndex];
    }
}

