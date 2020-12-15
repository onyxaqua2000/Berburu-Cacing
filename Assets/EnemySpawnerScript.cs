using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject cacing;

    public float minX;

    public float maxX;

    public float minY;

    public float maxY;

    Vector2 whereToSpawn;

    public float spawnRate = 2f;

    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2 (Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate (cacing, whereToSpawn, Quaternion.identity);
        }
    }
}
