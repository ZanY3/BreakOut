using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    int score = 0;
    public GameObject winScreen;
    public AudioSource source;
    public AudioClip winSound;
    public AudioClip loseSound;

    private void Start()
    {
        scoreText.text = "Score: 0";
    }
    private void Update()
    {
        if(FindObjectsOfType<Brick>().Length < 1)
        {
            source.PlayOneShot(winSound);
            winScreen.SetActive(true);
            Time.timeScale = 0;
            scoreText.gameObject.SetActive(false);
            healthText.gameObject.SetActive(false);
            enabled = false;
        }
    }
    public void ScorePlus()
    {
        score += 4;
        scoreText.text = "Score: " + score;
    }
    public void healthTextUpdate(int health)
    {
        healthText.text = "HP: " + health;
        if(health <= 0)
        {
            source.PlayOneShot(loseSound);
            enabled = false;
            
        }
    }    
}
