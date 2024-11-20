using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    public static LetterManager instance;
    private void Awake()
    {
        instance = this;
    }

    public List<string> selectedLetters = new List<string>();
    public Transform answerPanel;
    public Transform gameBoard;

    string lettersToDisplay = "";

    public void AddToList(string selectedLetter)
    {
        selectedLetters.Add(selectedLetter);
        Displayletters();
    }
    public void Displayletters()
    {
        lettersToDisplay = string.Empty;
        foreach (string letter in selectedLetters)
        {
            lettersToDisplay += letter;
        }
        answerPanel.GetComponent<TextMeshProUGUI>().text = lettersToDisplay;
    }
    //doent reset the letters/buttons so they dont function
    public void RemoveLastLetter()
    {
        selectedLetters.RemoveAt(selectedLetters.Count - 1);
        Displayletters();
    }
    public void ClearAll()
    {
        selectedLetters.Clear();
        foreach (Transform child in gameBoard)
        {
            child.GetComponent<Dice>().ResetLetter();
        }
        lettersToDisplay = string.Empty;
        Displayletters();
    }

    string word;
    int amountOfWordsFound;
    public TextAsset wordDictionary;
    public TextMeshProUGUI wordsFoundText;
    string wordsFound = "Words Found";

    List<string> wordsFoundList = new List<string>();
    public void SubmitList()
    {
        word = "";
        foreach (string letter in selectedLetters)
        {
            word = word + letter;
        }
        if (wordsFoundList.Contains(word))
        {
            Debug.Log("word already found");
        }
        else
        {
            //shows words found
            wordsFound = wordsFound + "\n" + word;
            wordsFoundText.text = wordsFound;

            //add word to list so cant put the same word in twice
            wordsFoundList.Add(word);

            amountOfWordsFound++;
            ClearAll();
        }
        //check if word is word
    }
}
