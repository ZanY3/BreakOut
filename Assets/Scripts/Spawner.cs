using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 size;
    public Vector2 brickSize;
    public GameObject brickPrefab;

    async void Start()
    {
        for (int y = 0; y < size.y; y++)
        {
            for (int x = 0; x < size.x; x++)
            {
                var pos = new Vector3(x * brickSize.x, y * brickSize.y, 0);
                Instantiate(brickPrefab, transform.position + pos, Quaternion.identity);
                await new WaitForSeconds(0.01f);
            }
        }
    }
}
