using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 4.0f;
    public AudioSource rocketNoise;
    public Animator rocketAnimator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            speed=10.0f;
            rocketNoise.pitch = 2f;
            rocketNoise.volume = 1.0f;
            rocketAnimator.SetBool("Boost", true);

        }
        
        if(Input.GetButtonUp("Jump")){
            speed=4.0f;
            rocketNoise.pitch = 1.0f;
            rocketNoise.volume = 0.77f;
            rocketAnimator.SetBool("Boost", false);
        }

        Debug.Log("Nopeus: " + speed);
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
