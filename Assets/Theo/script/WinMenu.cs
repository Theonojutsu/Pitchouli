using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Start()
    {
        Global.previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(Global.previousSceneIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
