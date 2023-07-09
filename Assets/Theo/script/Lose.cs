using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    private Camera mainCamera;
    private float limiteGauche;
    private bool canLose = false;

    void Start()
    {
        mainCamera = Camera.main;
        limiteGauche = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
    }

    void Update()
    {
        if (transform.position.x <= limiteGauche)
        {
            canLose = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Spike") || (collision.gameObject.tag == "Finish") || (canLose == true))
        {
            SceneManager.LoadScene(0);
        }
    }
}

