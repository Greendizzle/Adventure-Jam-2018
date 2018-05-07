using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public int jumpForce;
    public Rigidbody2D Rb;
    public int MovementSpeed;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        

        Rb.velocity = new Vector2(horizontal * MovementSpeed, vertical);


    }

    
}


