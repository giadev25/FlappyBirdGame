using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text scoreText;

    int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }

    void Update()
    {
        scoreText.text = score.ToString();    
    }

}
