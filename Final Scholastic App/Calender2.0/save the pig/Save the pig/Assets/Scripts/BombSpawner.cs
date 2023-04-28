using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    public float XPositionLimit;
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBomb()
    {
        float Randomx = Random.Range(-XPositionLimit, XPositionLimit);

        Vector2 SpawnPosition = new Vector2(Randomx, transform.position.y);

        Instantiate(bomb, SpawnPosition, Quaternion.identity); 
       
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnBomb", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnBomb");
    }
}
