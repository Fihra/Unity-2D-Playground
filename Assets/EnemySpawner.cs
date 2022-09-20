using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    //[SerializeField]
    //private List<GameObject> enemies = new List<GameObject>();
    [SerializeField]
    private int maxAmountOfEnemies = 5;
    [SerializeField]
    private float SpawnTime = 3.0f;

    float timer = 0;
    public static int enemiesSpawned = 0;

    private Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if(timer >= SpawnTime)
        {
            if(enemiesSpawned < maxAmountOfEnemies)
            {
                Instantiate(enemy, spawnPoint, Quaternion.identity);
                enemiesSpawned++;
                timer = 0;
            }
        }
    }
}
