using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        AudioManager.instance.PlayAudio("BG");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        AudioManager.instance.PlayAudio("BG");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
