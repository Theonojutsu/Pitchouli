using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBound : MonoBehaviour
{
    public Transform pointDR;
    public Transform pointUL;
    public Transform originPlayer;
    private Transform camTransfo;
    private float cameraHalfHeight;
    private float cameraHalfWidth;

    void Start()
    {
        camTransfo = gameObject.transform;
        Camera cam = gameObject.GetComponent<Camera>();

        // Set the ratio of the cam
        cameraHalfHeight = cam.orthographicSize;
        cameraHalfWidth = cam.aspect * cameraHalfHeight;
    }

    void Update()
    {

        float posVert;

        // Boundaries of the cam
        posVert = Mathf.Clamp(originPlayer.position.y, pointDR.position.y + cameraHalfHeight, pointUL.position.y + cameraHalfHeight);

        camTransfo.position = new Vector3(transform.position.x, posVert, camTransfo.position.z);
    }
}