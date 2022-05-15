using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
