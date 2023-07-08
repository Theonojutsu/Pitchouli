using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpace();
        }
    }

    public void OnSpace()
    {
        SceneManager.LoadScene(Global.previousSceneIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
