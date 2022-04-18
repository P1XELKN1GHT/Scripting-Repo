using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("Player Info.")]
    public float speed;
    public float jumpheight;

    [Header("Ground?")]
    private Rigidbody2D RB;
    private bool isGrounded;
    public Transform groundcheck;
    public float groundcheckRadius;
    public LayerMask isitground; 

    private float moveVelocity;

   
    void Start()
    {
        isGrounded = true;
        RB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckRadius, isitground); //ground checking sensor

        moveVelocity = 0f; // Non-stick player

        if(Input.GetKeyDown(KeyCode.Space))
       {
           Jump();
       }


        if(Input.GetKey(KeyCode.D))
       {
           moveVelocity = speed;
       }
       if(Input.GetKey(KeyCode.A))
       {
        moveVelocity = speed;
       }

       RB.velocity = new Vector2(moveVelocity, RB.velocity.y); // move player left & right
    }

    // Update is called once per frame
    void Update()
    {
       
       
       
      
    }
    public void Jump()
    {
        RB.velocity = new Vector2(RB.velocity.x, jumpheight);
    }
}
