using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Letters : MonoBehaviour
{
    public static Letters instance;
    int maxLetters = 10;
    private void Awake()
    {
        instance = this;
    }

    public List<string> letters = new List<string>();
    public GameObject answerPrefab;
    public Transform answerParent;

    public void AddToList(string letter)
    {
        if (letter.Length < maxLetters)
        {
            letters.Add(letter);
            answerPrefab.GetComponentInChildren<TextMeshProUGUI>().SetText(letter);
            Instantiate(answerPrefab, answerParent);
        }
    }
    public void RemoveLetter(string letter)
    {
        letters.Remove(letter);
    }
}
