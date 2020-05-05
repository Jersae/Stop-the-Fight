using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public void GoToScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("Level01");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
