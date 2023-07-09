using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        SceneManager.LoadScene(1);
    }
}

        
    
            
        