using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllSceneManager : MonoBehaviour
{
    public void toGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void toHowToPlay()
    {
        SceneManager.LoadScene("How to play");
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}