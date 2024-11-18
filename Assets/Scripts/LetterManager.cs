using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    public static LetterManager instance;
    int maxLetters = 10;
    private void Awake()
    {
        instance = this;
    }

    public List<string> letters = new List<string>();
    public GameObject answerPrefab;
    public Transform answerPanel;

    public void AddToList(string letter)
    {
        if (letter.Length < maxLetters)
        {
            letters.Add(letter);
            answerPrefab.GetComponentInChildren<TextMeshProUGUI>().SetText(letter);
            Instantiate(answerPrefab, answerPanel);
        }
    }
    public void RemoveLastLetter()
    {
        int childAmount = answerPanel.childCount;
        letters.RemoveAt(childAmount -1);
        Destroy(answerPanel.GetChild(childAmount -1).gameObject);
    }
    public void ClearAll()
    {
        foreach (Transform child in answerPanel)
        {
            Destroy(child.gameObject);
        }
        letters.Clear();
    }

    string word;
    int amountOfWordsFound;
    public TextMeshProUGUI wordsFoundText;
    string wordsFound = "Words Found";

    List<string> wordsFoundList = new List<string>();
    public void SubmitList()
    {
        if (letters.Count > 2)
        {
            word = "";
            foreach (string letter in letters)
            {
                word = word + letter;
            }
            if (wordsFoundList.Contains(word))
            {
                Debug.Log("word already found");
            }
            else
            {
                //check if word is word

                //shows words found
                wordsFound = wordsFound + "\n" + word;
                wordsFoundText.text = wordsFound;

                //add word to list so cant put the same word in twice
                wordsFoundList.Add(word);

                amountOfWordsFound++;
                ClearAll();
            }

        }
        
    }
}
