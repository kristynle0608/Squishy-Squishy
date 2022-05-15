using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LevelsScreen()
    {
        SceneManager.LoadScene("Levels Screen");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
