using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spike")
        {
            SceneManager.LoadScene(0);
        }
    }
}

