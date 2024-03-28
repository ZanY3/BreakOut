using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    int score = 0;
    private void Start()
    {
        scoreText.text = "Score: 0";
    }
    public void ScorePlus()
    {
        score += 4;
        scoreText.text = "Score: " + score;
    }
    public void healthTextUpdate(int health)
    {
        healthText.text = "HP: " + health;
    }    
}
