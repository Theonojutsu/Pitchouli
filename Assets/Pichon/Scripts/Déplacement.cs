using UnityEngine;

public class Déplacement : MonoBehaviour
{
    public float speed = 1f; // Vitesse de déplacement de l'objet

    private void Update()
    {
        // Calculer le déplacement en fonction de la vitesse et du temps écoulé depuis la dernière frame
        float moveAmount = speed * Time.deltaTime;
         
        // Déplacer l'objet sur l'axe x
        transform.Translate(Vector2.right * moveAmount);
    }
}
