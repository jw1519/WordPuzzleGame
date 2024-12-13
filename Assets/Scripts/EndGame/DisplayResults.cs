using TMPro;
using UnityEngine;

public class DisplayResults : MonoBehaviour
{
    public TextMeshProUGUI amountOfWordsText;
    int amountOfWordsFound;

    void Start()
    {
        amountOfWordsFound = LetterManager.instance.wordsFoundList.Count;
        amountOfWordsText.text = $"You found {amountOfWordsFound} words";
    }
}
