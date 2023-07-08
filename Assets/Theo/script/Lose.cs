using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    void OnBecameInvisible()
    {
        SceneManager.LoadScene(0);
    }
}

