using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int health = 3;

    private bool tempInvulnerable = false;
    private BoxCollider2D triggerCollider;

    private SpriteRenderer sprite;

    private void Awake()
    {
        triggerCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    public void LoseHealth()
    {
        
        //if (tempInvulnerable) return;
        if (!tempInvulnerable)
        {
            health--;
            Debug.Log(health);
            Debug.Log("Get Hurt");
            tempInvulnerable = true;
            if (health < 1)
            {
                Destroy(gameObject);
                gameObject.SetActive(false);
            }

            StartCoroutine("GetInvulnerable");
        }
    }

    public IEnumerator GetInvulnerable()
    {
        sprite.color = Color.red;
        //triggerCollider.isTrigger = false;
        yield return new WaitForSeconds(2f);
        //triggerCollider.isTrigger = true;
        tempInvulnerable = false;
        sprite.color = Color.white;
    }
}
