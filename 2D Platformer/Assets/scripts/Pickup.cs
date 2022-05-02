using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, THEORB_ponderit, Money};
    public PickupType currentPickup;
    public int pickupQuantity;
    private PlayerController2D playerOne;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.Find("Character").GetComponent<PlayerController2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerOne.Key = pickupQuantity;
                print("You Picked up a Key!");
            }
            else if(currentPickup == PickupType.THEORB_ponderit)
            {
                playerOne.THEORB_ponderit = pickupQuantity;
                print("You found " + pickupQuantity + "THE ORB");
            }
            else if(currentPickup == PickupType.Money)
            {
                playerOne.Money = pickupQuantity;
                print("You got" + pickupQuantity + "money");
            }
            
            Destroy(gameObject);
        }
    
    }
}
