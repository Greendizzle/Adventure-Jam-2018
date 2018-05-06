using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    

    public float movementSpeed;
    public Transform[] groundpoints;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        

       Movement(horizontal);
	}

    private void Movement(float horizontal)
    {
        

        rb.velocity = new Vector2(horizontal*movementSpeed, rb.velocity.y);
    }
}
