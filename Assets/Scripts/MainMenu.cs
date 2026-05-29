using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        AudioManager.instance.PlayAudio("MainMenuBg");
    }

    public void StartGame()
    {
        AudioManager.instance.PlayAudio("Start");
        AudioManager.instance.StopAudio("MainMenuBg");
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
