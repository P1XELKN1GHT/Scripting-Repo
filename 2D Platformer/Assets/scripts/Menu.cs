using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int sceneToLoad;
    
    public void StartGame()
    {
        SceneManager.LoadScene(1); //Scene to load
    }
    public void QuitGame()
    {
        Application.Quit();// Quit game
        print("Quit Game");// Print to console
    }
}
