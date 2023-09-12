using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public int score;
    public GameObject scoreText;
    public AudioClip chimeSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Star"))
        {
            score += 100;
            scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE: " + score.ToString();
            GetComponent<AudioSource>().PlayOneShot(chimeSound);
            Destroy(other.gameObject);
        }
    }
}
