using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Cmon");
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided");
            Destroy(other.gameObject);
        }
    }
}
