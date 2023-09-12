using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{

    public float speed = 2;
    public float changeTime = 3;
    private float savedTime;

    // Start is called before the first frame update
    void Start()
    {
        savedTime = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        changeTime -= Time.deltaTime;

        if(changeTime < 0)
        {
            changeTime = savedTime;
            speed = -speed;
        }
        
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
    }
}
