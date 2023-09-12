using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeedX, rotateSpeedY, rotateSpeedZ;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeedX,rotateSpeedY,rotateSpeedZ);
    }
}
