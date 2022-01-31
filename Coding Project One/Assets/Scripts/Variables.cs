using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int Credits; 
    public int Arrows;
    public float scrap; 
    public bool isDay;
    public string UserName = "UserName002";
    public bool helmet;
    public bool weapon;
    public string weather;
    

    // Start is called before the first frame update
    void Start()
    {
        Credits = 150;
        print("Credits in account = $" + Credits);
        Debug.Log("Game Start!");
        Arrows = 45;
        print("Arrows in Quiver = #" + Arrows);
        scrap = 0.84f;
        Debug.Log("scrap in bag = *" + scrap);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDay == true)
        {
            print("It is not night");
        }
        else if (isDay == false)
        {
            print("It is now night");
        }
        if (helmet == true && weapon == true)
        {
            print("It is safe to leave the community");
        }
        else if (helmet == false && weapon == false)
        {
            print("you may not leave the safetey of the village"); 
        }
        else if (helmet == false && weapon == true)
        {
            print("you will probaly die");
        }
        else if (helmet == true && weapon == false)
        {
            print("you need to get a weapon you idiot!");
        }
        if( weather == "rain" || weather == "snow")
        {
            print("You are now wet");
        }
        else if (weather == "sunny" || weather == "windy")
        {
            Debug.Log("you are dry");
        }
    }
}
