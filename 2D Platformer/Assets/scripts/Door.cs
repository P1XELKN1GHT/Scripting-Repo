using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private PlayerController2D character;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Character").GetComponent<PlayerController2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && character.Key == 1)
        {
            print("The door is now Open!");
            Destroy(gameObject);
        }
        else
        {
           print("Door is locked. Find a key first.");
        }
    }
}
