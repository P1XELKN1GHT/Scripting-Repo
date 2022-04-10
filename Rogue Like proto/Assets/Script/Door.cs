using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Controller playerOne;
    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.Find("Player").GetComponent<Controller>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerOne.Key == 1)
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
