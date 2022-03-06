using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float movespeed = 5.0f; //PLayers movement spped in game
    Rigidbody2D rb; // rigid body reference storage
    Vector2 movement; // x, y movement storage
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

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime); // physics and player movement
    }
}
