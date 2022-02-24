using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //keep track of the current score
    public TextMeshProUGUI scoreText; //text object to be edited
    // Start is called before the first frame update
    void Start()
    {
        updatescoretext();
    }

        public void IncreaseScoreText(int amount)
    {
        score += amount;
        updatescoretext();
    }
    public void DcreaseScoreText(int amount)
    {
        score -= amount;
        updatescoretext();
    }
    public void updatescoretext()
    {
        scoreText.text = "score: " + score;
    }
}
