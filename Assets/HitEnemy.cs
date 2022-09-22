using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy");
            Destroy(other.gameObject);
            if (EnemySpawner.enemiesSpawned > 0)
            {
                EnemySpawner.enemiesSpawned--;
            }
        }
    }
}
