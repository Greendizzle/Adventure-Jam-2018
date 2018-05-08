using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float horizontal = 0f;
    private Rigidbody2D rigidBody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private bool facingRight;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
<<<<<<< HEAD
=======
        facingRight = true;
>>>>>>> 93bbc355cbcd1f9e36601ce2ddb3a530f30b291b
        rigidBody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
       
        flip(horizontal);

        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);

        if (horizontal > 0f)
        {
            rigidBody.velocity = new Vector2(horizontal * speed, rigidBody.velocity.y);
        }
        else if (horizontal < 0f)
        {
            rigidBody.velocity = new Vector2(horizontal * speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);

        }

    }
    private void flip(float horizontal) {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;

            theScale.x *= -1;
            transform.localScale = theScale;


        }

    }


    
}




