using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToHelp()
    {
        SceneManager.LoadScene("HelpScene");
    }
}

