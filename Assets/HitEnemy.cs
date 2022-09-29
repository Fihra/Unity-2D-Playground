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
            Vector2 difference = other.transform.position - transform.position;
            other.transform.position = new Vector2(other.transform.position.x + difference.x, other.transform.position.y + difference.y);

            Destroy(other.gameObject);
            if (EnemySpawner.enemiesSpawned > 0)
            {
                EnemySpawner.enemiesSpawned--;
            }
        }
    }
}
