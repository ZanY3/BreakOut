using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] float hp = 2;
    public GameObject particles;
    public AudioSource source;
    public AudioClip destroySound;
    private void Update()
    {
        if (hp <= 0)
        {
            source.PlayOneShot(destroySound);
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    public void Damage()
    {
        hp--;

    }

}
