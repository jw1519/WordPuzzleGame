using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
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
        //gameObject.GetComponent<Button>().enabled = false; 
        //gameObject.GetComponent<Image>().color = Color.red;
        LetterManager.instance.AddToList(character);
    }
    public void RemoveLetter()
    {
        gameObject.GetComponent<Button>().enabled = true;
        gameObject.GetComponent<Image>().color = Color.white;
    }
}
