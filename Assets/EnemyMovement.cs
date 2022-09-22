using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    //[SerializeField]
    //private float range = 3.0f;
    [SerializeField]
    private float minRange = 0.15f;
    [SerializeField]
    private float maxRange = 0.75f;


    private Vector2 movement;
    private Transform playerPosition;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        if(Vector3.Distance(playerPosition.position, transform.position) <= maxRange && Vector3.Distance(playerPosition.position, transform.position) >= minRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition.transform.position, step);
            //rb.MovePosition(Vector3.MoveTowards(transform.position, playerPosition.transform.position, step));
            //rb.velocity = Vector3.MoveTowards(transform.position, playerPosition.transform.position, step);
        }

        //if(Vector3.Distance(playerPosition.position, transform.position) <= range)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, playerPosition.transform.position, step);
        //}

        //Vector3 currentPos = Vector3.MoveTowards(transform.position, playerPosition, step);
        
        //rb.MovePosition(currentPos);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Player>().LoseHealth();
        }

        if (other.CompareTag("Hit"))
        {
            Debug.Log("Hit in Here");
            Vector2 difference = transform.position - other.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);

        }
    }
}
