using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Player Health")]
    public int curHp;
    public int maxHp;

    [Header("Player Move")]
    public float movespeed = 5.0f; //PLayers movement spped in game
    Rigidbody2D rb; // rigid body reference storage
    Vector2 movement; // x, y movement storage
    Vector2 direction;

    [Header("Round 1... FIGHT, (Combat)")]
    public float atkRange; // range that the player can attack
    public float atkRate; // rate at which player attcks
    float lastAtkTime; // last time the player attcked... probably
    public int dmg; // damage dealt to enemy
    public LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // left right movemenet input
        movement.y = Input.GetAxis("Vertical"); // up down input

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAtkTime >= atkRate)
                Attack();
        }

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime); // physics and player movement

        updatedirection();
    }
    void updatedirection()
    {
        Vector2 veloc = new Vector2(movement.x,movement.y);// veloc is velocity

        if(veloc.magnitude != 0)
        {
            direction = veloc;
        }
        rb.velocity = veloc * movespeed;

    }

    void Attack()
    {
        lastAtkTime = Time.time; // Raycast using the enemy layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, atkRange, enemyLayer);
        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enmy>()?.TakeDamage(dmg);
        }
    }
     void Die()
    {
        print("Player has died");
    }
     public void TakeDamage(int dmg)
    {
        curHp -= dmg;

        if(curHp == 0)
        {
            Die();
        }
    }    
}

