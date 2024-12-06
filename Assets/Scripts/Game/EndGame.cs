using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void GameFinished()
    {
        SceneManager.LoadScene("EndgameScene");
    }
}
