using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    public string selectedLetter;
    void Start()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        GenerateLetter();
    }
    void GenerateLetter()
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char letter = letters[Random.Range(0, letters.Length)];
        selectedLetter = letter.ToString();
        textMesh.SetText(selectedLetter);
    }
    public void OnLetterClicked()
    {
        gameObject.GetComponent<Button>().enabled = false;
        gameObject.GetComponent<Image>().color = Color.red;
        LetterManager.instance.AddToList(selectedLetter);
    }
    public void ResetLetter()
    {
        gameObject.GetComponent<Button>().enabled = true;
        gameObject.GetComponent<Image>().color = Color.white;
    }
}
