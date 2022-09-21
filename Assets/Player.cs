using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int health = 3;

    private bool tempInvulnerable = false;
    private BoxCollider2D triggerCollider;

    private void Awake()
    {
        triggerCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if !Invinisble
        if (!tempInvulnerable && other.CompareTag("Enemy"))
        {
            Debug.Log(health);
            health--;
            tempInvulnerable = true;
            if (health < 0)
            {
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
            StartCoroutine("GetInvulnerable");
        }
    }

    public IEnumerator GetInvulnerable()
    {
        triggerCollider.isTrigger = false;
        yield return new WaitForSeconds(2f);
        triggerCollider.isTrigger = true;
        tempInvulnerable = false;
    }
}
