using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloonie : MonoBehaviour
{

    public int givescore = 100; //score for each balloon popped

    public int clicks2pop = 5; //clicks it takes to pop each balloon

    public float scaleup = 0.10f; // scaa;e increase for each click on a balloon

    public ScoreManager scoreManager; //used to reference the score manage script


    // Start is called before the first frame update
    void Start()

    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    
    void OnMouseDown()
    {
        clicks2pop -= 1; //reduce clicks by one
        transform.localScale += Vector3.one * scaleup; // (.one is used to increas x,y, and z) used to increase the size of the balloons

        if (clicks2pop == 0)
        {
            scoreManager.IncreseScoreText(scoretogive);
            Destroy(gameObject);
        }

    }

}
