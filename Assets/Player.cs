using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int health = 3;

    BoxCollider2D triggerCollider;

    private void Awake()
    {
        triggerCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log(health);
            health--;
            if (health < 1)
            {
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
            StartCoroutine("GetInvulnerable");
        }
    }

    IEnumerator GetInvulnerable()
    {
        triggerCollider.isTrigger = false;
        yield return new WaitForSeconds(2f);
        triggerCollider.isTrigger = true;
    }
}
