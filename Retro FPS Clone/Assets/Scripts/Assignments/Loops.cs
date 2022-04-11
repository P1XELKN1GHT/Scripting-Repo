using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    public int numEwoks = 20;
    public int ducks = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 0; i <= numEwoks; i++)// will have a finate amount of times it loops, i++ is short hand for i+1, can also be used as i--
        {
            Debug.Log("There are" + i + "Ewoks on a log!");
        }*/
        while(ducks >0) // The same is true for counting up, but using <0 rather than >0. [Make sure the Inspector isnt overinding the code.]
        {
            print(ducks);
            print("All the ducks have flown south for winter.");
            ducks --;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
