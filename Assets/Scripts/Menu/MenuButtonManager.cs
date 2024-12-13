using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OpenSettings()
    {

    }
    public void Quit()
    {
        Application.Quit();
    }
}
