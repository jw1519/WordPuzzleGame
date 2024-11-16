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

        //Transform child = answerPanel.GetChild(childAmount);
        //child.GetComponent<>
    }
    public void ClearAll()
    {
        foreach (Transform child in answerPanel)
        {
            Destroy(child.gameObject);
        }
        letters.Clear();
    }
}
