using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class LetterManagerTests
{
    // A Test behaves as an ordinary method
    [UnitySetUp]
    public IEnumerator SetUp()
    {
        SceneManager.LoadScene("GameScene");
        yield return null;
    }

    [UnityTest]
    public IEnumerator LetterManager_AddToListAppendsCorrectly()
    {
        var Dice = GameObject.FindAnyObjectByType<Dice>();
        yield return null;
        Assert.NotNull(Dice);

        Dice.GetComponent<Button>().onClick.Invoke();
        yield return null;
        Assert.IsTrue(LetterManager.instance.selectedLetters.Contains(Dice.GetComponent<Dice>().selectedLetter));

    }
}
