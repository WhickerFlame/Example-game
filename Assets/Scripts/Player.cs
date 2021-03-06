﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public string logtext = "Hello world again";
    public float speed = 2;
    public float jumpspeed = 2;
    public float health = 100;
    // Use this for initialization
    void Start () {
        Debug.Log(logtext);
        Debug.Log("Hey world");
        Debug.Log("Ola world");
        Debug.Log("Sup world");
        Debug.Log("Konnichiwa world");
        
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Konnichiwa world");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //Number beteen -1 and 1 based uponplayer presing left or right/a or d
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        //Boolean (true or false) based or player pressing space bar
        bool jump = Input.GetButtonDown("Jump");

        //Find out if touching the ground
        //get the collider component attached to this object
        Collider2D collider = GetComponent<Collider2D>();
        //Find out if we are coliding with the ground 
        LayerMask GroundLayer = LayerMask.GetMask("Ground");
        bool touchinGround = collider.IsTouchingLayers(GroundLayer);
        //caache a local copy of or rigidbody's velocity
        Vector2 velocity = rigidbody.velocity;

        //set the x (left/right/a/d) components of the velocty bsed on our input
        velocity.x = horizontal*speed;
        //set the y (up/down) component of the velocity based on jump
        if (jump==true && touchinGround==true)
        {
            velocity.y = jumpspeed;
        }
        //set our ridgedbody's velocity based on our local copy
      rigidbody.velocity= velocity;

        //print a log when the mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            //print a log of mouse position
            Vector2 mousePosition = Input.mousePosition;
            Debug.Log("Mouse position is" +mousePosition);
               
        }


    }
    public void ApplyDeath(float DammageDealt)
    {
        health = health - DammageDealt;
    }
}
