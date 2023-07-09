using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    private Camera mainCamera;
    private float limiteGauche;

    void Start()
    {
        mainCamera = Camera.main;

    }

    void Update()
    {
        limiteGauche = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
        Debug.Log(limiteGauche);

        if (transform.position.x <= limiteGauche)
        {
            SceneManager.LoadScene(0);
            
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Spike"))
        {
            SceneManager.LoadScene(0);
        }
    }
}

