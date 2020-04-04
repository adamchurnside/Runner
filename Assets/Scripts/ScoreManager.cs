using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreDisplay.text = "Score: " + score.ToString();
        if (collision.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
