using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zooms : MonoBehaviour
{
    #region Variables

    public Camera cameraToControl;
    public float zoomSpeed = 15f;
    private bool isZooming = false;
    private bool isZoomingOut = false;
    private bool onZone = false;

    private float camPos;
    public GameObject deathZone;
    public GameObject camera2;


    #endregion

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fond")
        {
            onZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fond")
        {
            onZone = false;
        }
    }

    void FixedUpdate()
    {
        if (!isZooming && onZone == false && !isZoomingOut)
        {
            StartCoroutine(ZoomOut());
        }
        else if (!isZooming && onZone == true && isZoomingOut)
        {
            StartCoroutine(ZoomIn());
        }
    }

    IEnumerator ZoomOut()
    {
        isZooming = true;
        isZoomingOut = true;
        while (cameraToControl.orthographicSize < 25)
        {
            cameraToControl.orthographicSize += zoomSpeed * Time.deltaTime;
            yield return null;
        }
        isZooming = false;
    }

    IEnumerator ZoomIn()
    {
        isZooming = true;
        isZoomingOut = false;
        while (cameraToControl.orthographicSize > 6)
        {
            cameraToControl.orthographicSize -= zoomSpeed * Time.deltaTime;
            yield return null;
        }
        isZooming = false;
    }
}
