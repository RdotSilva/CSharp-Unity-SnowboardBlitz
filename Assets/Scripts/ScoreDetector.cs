using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetector : MonoBehaviour
{
    Score score;
    private void Start()
    {
        score = GetComponent<Score>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Score")
        {
            score.IncrementScore();
        }
    }
}
