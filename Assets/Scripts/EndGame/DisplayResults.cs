using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayResults : MonoBehaviour
{
    public TextMeshProUGUI amountOfWordsText;
    static int amountOfWordsFound;

    void Start()
    {
        amountOfWordsFound = LetterManager.instance.wordsFoundList.Count;
        amountOfWordsText.text = $"You found {amountOfWordsFound} words";
    }


}