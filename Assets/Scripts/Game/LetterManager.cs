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
    public TextAsset wordsTextAsset;
    public List<string> wordList = new List<string>();

    string lettersToDisplay = "";

    Trie wordTrie;
    public void Start()
    {
        wordTrie = new Trie();
        string[] lines = wordsTextAsset.text.Split("\n");
        wordList = new List<string>(lines);
        
        
        foreach (string word in wordList)
        {
            wordTrie.Insert(word.Trim().ToLower());
        }
    }

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

    public TextMeshProUGUI wordsFoundText;
    string wordsFound = "Words Found: \n";

    public string GetCurrentWord()
    {
        return string.Join("", selectedLetters);
    }
    [SerializeField] public List<string> wordsFoundList = new List<string>();
    public void SubmitWord()
    {
        string currentWord = GetCurrentWord().ToLower();
        Debug.Log(currentWord.Length);

        if (wordTrie.Search(currentWord) && currentWord.Length !<= 2)
        {
            if (wordsFoundList.Contains(currentWord))
            {
                Debug.Log("word already found");
            }
            else
            {
                //shows words found
                wordsFound = wordsFound + currentWord + ", ";
                wordsFoundText.text = wordsFound;

                //add word to list so cant put the same word in twice
                wordsFoundList.Add(currentWord);
                ClearAll();
            }
        }
        else
        {
            Debug.Log("word not found");
        }
    }
}
