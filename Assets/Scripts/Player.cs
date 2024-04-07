using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    public static int hp = 2;
    public GameObject hideCanvas; //hide after lose ui
    public GameObject loseWindow;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
    private void Update()
    {
        Time.timeScale = 1;
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        if(hp <= 0)
        {
            hideCanvas.SetActive(false);
            loseWindow.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    public void HealthMinus()
    {
        hp--;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            var offset = transform.position - collision.transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(offset.x, -1);

        }
    }
}
