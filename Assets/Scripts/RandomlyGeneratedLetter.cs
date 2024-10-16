using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomlyGeneratedLetter : MonoBehaviour
{
    public TextMeshProUGUI TextMesh;

    void Start()
    {
        GenerateLetter();
    }
    void GenerateLetter()
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char letter = letters[Random.Range(0, letters.Length)];
        string character = letter.ToString();
        TextMesh.SetText(character);
    }
}
