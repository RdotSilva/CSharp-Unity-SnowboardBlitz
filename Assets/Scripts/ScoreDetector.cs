using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDetector : MonoBehaviour
{
    private Score score;
    private void Start()
    {
        score = FindObjectOfType<Score>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            score.IncrementScore();
            // TODO: TEST THIS This is a potential fix for score being counted twice
            Physics2D.IgnoreCollision(other, GetComponent<Collider2D>());
        }
    }
}
