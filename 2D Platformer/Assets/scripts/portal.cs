using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{


   
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
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
