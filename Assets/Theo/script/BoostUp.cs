using UnityEngine;

public class BoostUp : MonoBehaviour
{
    public float forceAmount = 10f; // Force à appliquer sur l'axe X
    public Rigidbody2D targetRigidbody; // Rigidbody2D de l'objet cible

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifier si la collision implique l'objet cible
        if (collision.gameObject.GetComponent<Rigidbody2D>() == targetRigidbody)
        {
            // Appliquer la force sur l'axe X en utilisant AddForce()
            targetRigidbody.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);
        }
    }
}
