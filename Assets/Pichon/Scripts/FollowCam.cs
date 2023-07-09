using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCam : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        Global.previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        float posPlayer = player.transform.position.x;

        if (posPlayer >= transform.position.x)
        {
            transform.position = new Vector3(posPlayer, transform.position.y, transform.position.z);
        }
    }
}
