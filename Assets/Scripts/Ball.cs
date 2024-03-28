using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    GameManager gameManager;
    Player player;
    public int health = 2;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindAnyObjectByType<GameManager>();
        player = FindAnyObjectByType<Player>();
    }
    private void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var brick = collision.gameObject.GetComponent<Brick>();   
        if (brick != null)
        {
            gameManager.ScorePlus();
            brick.Damage();
        }
        if(collision.gameObject.name.Contains("LoseTrigger"))
        {
            player.HealthMinus();
            health--;
            gameManager.healthTextUpdate(health);
        }
    }
}
