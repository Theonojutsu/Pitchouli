using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    private float rotationSpeed = 90f;

    void FixedUpdate()
    {
        Rotate(1);
    }

    void Rotate(float a)
    {
        transform.Rotate(Vector3.forward, a * rotationSpeed * Time.deltaTime);
    }
}
