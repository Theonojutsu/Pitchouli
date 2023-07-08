using UnityEngine;

public class DisableLine : MonoBehaviour
{
    public GameObject lineObject; // R�f�rence vers l'objet "Line" � d�sactiver

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerObject"))
        {
            lineObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerObject"))
        {
            lineObject.SetActive(true);
        }
    }
}
