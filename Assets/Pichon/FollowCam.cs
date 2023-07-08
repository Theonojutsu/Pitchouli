using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        float posPlayer = player.transform.position.x;

        if (posPlayer >= transform.position.x)
        {
            transform.position = new Vector3(posPlayer, transform.position.y, transform.position.z);
        }
    }
}
