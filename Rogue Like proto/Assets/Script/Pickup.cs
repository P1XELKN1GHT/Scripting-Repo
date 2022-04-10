using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Gold, Crystals};
    public PickupType currentPickup;
    public int pickupQuantity;
    private Controller playerOne;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.Find("Player").GetComponent<Controller>();
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
            else if(currentPickup == PickupType.Gold)
            {
                playerOne.Gold = pickupQuantity;
                print("You found " + pickupQuantity + "Gold");
            }
            else if(currentPickup == PickupType.Crystals)
            {
                playerOne.Crystals = pickupQuantity;
                print("You found " + pickupQuantity + "Crystals");
            }
            Destroy(gameObject);
        }
    
    }
}
