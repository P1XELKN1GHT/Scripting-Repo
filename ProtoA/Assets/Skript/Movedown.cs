using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedown : MonoBehaviour
{
    public float movespeed = 1.0f;

    public float lowerboundry = -7.0f;

    public ScoreManager scoreManager;

    public Balloonie balloon;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloonie>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move the balloon down the screen
        transform.Translate(Vector3.down * Time.deltaTime);

        //Destroy balloon if it passes the boundry
        if(transform.position.y < lowerboundry)
        {
            scoreManager.DecreaseScoreText(balloon.score2give);
            Destroy(GameObject);
        }
        
    }
}
