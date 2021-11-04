using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    private int scoreNum;

    void Start()
    {
        scoreNum = 0;
        score.text = "Score: " + scoreNum;
    }

    public void IncrementScore()
    {
        scoreNum++;
        score.text = "Score: " + scoreNum;
    }
}
