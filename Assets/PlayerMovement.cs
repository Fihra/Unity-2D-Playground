using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 10.0f;

    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Inputs();
        Movement();
    }

    void Inputs()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        movement = new Vector2(horizontal, vertical).normalized;
    }

    void Movement()
    {
        Debug.Log(movement);
        //rb.AddForce(movement * speed * Time.fixedDeltaTime);
        rb.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }
}
