using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Transform startPos;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Asteroid"))
        {
            transform.position = startPos.position;
        }
    }
}
