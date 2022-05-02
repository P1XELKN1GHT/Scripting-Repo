using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("Player Info.")]
    public float speed;
    public float jumpheight;

    [Header("Ground?")]
    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform groundcheck;
    public float groundcheckRadius;
    public LayerMask isitground; 

    private float moveVelocity;

    public AudioClip clip;
    
    private AudioSource source;

    [Header("Health")]
    public int curhp;
    public int maxhp;

    [Header("Inventory")]
    public int Key;
    public int THEORB_ponderit;
    public int Money;

     
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();

        source = GetComponent<AudioSource>();

    }

    void Update()
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
            moveVelocity = -speed;
       }

        rb.velocity = new Vector2(moveVelocity, rb.velocity.y); // move player left & right
        
    }
    
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpheight);
        source.PlayOneShot(clip, 1.0f);
    }
    
    
    public void TakeDamage(int damage)
    {
        curhp -= damage;
        if(curhp <= 0)
        {
            QuitGame();
        }
    }
    public void QuitGame()
    {
        Application.Quit();// Quit game
        print("Quit Game");// Print to console
    }
}
