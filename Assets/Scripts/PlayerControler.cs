using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float groundRadius = .2f;
    public Transform groundCheck;
    private Rigidbody2D rb;
    private Collider2D c2d;
    public LayerMask ground;
    public bool canJump = false;
    public bool jumpPressed = false;
    public bool isGrounded = false;
    public float moveFactor = 0.1f;
    public float jumpFactor = 100.0f;
    public bool jumping = false;
    private float moveX;

    // Get references to our collider and rigidbody
    void Start()
    {
        c2d = this.GetComponent<Collider2D>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Process inputs once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
 
        jumpPressed = Input.GetAxis("Jump") > 0;

    }

    // Do the physics thing
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(new Vector2(groundCheck.position.x, groundCheck.position.y), groundRadius, ground);
        if ((jumpPressed && isGrounded))
        {
            rb.AddForce(new Vector2(0f, jumpFactor));
            jumping = true;
        }
        else jumping = false;
        rb.AddForce(new Vector2(moveX*10, 0));
    }
   
}