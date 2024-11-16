using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomlyGeneratedLetter : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    public string character;

    void Start()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        GenerateLetter();
    }
    void GenerateLetter()
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char letter = letters[Random.Range(0, letters.Length)];
        character = letter.ToString();
        textMesh.SetText(character);
    }
    public void AddLetter()
    {
        Letters.instance.AddToList(character);
    }
}
