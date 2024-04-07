using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 0;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    void Update()
    {
        livesText.text = "HP: " + lives;
        scoreText.text = "Score : " + score;

        // GAME OVER
        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            print("GAME OVER");
            enabled = false;
        }

        // WIN
        if (FindObjectsOfType<Brick>().Length < 1)
        {
            winScreen.SetActive(true);
            print("YOU WIN");
            enabled = false;
        }
    }
}
