using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject itemObject;
    GameObject[] enemies;
    bool isGameActive = true;
    public bool doorUnlocked = false;

    void Start()
    {
        AudioManager.instance.PlayAudio("BossBg");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log(enemies);
    }

    void Update()
    {
        if (isGameActive == false)
            return;

        foreach (var enemy in enemies)
        {
            if (enemy.activeInHierarchy == true)
                return;
        }
        itemObject.SetActive(true);
        if (!doorUnlocked)
            return;

        winScreen.SetActive(true);
        AudioManager.instance.PlayAudio("Win");

        isGameActive = false;
    }

    public void Restart()
    {
        AudioManager.instance.PlayAudio("Start");
        SceneManager.LoadScene(2);
    }
    public void ToMainMenu()
    {
        AudioManager.instance.PlayAudio("UI");
        AudioManager.instance.StopAudio("BossBg");
        SceneManager.LoadScene(0);
    }

    public void BossGame()
    {
        SceneManager.LoadScene(3);
    }
}
