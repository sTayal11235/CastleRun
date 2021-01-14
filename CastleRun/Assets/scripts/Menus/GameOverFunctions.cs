using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverFunctions : MonoBehaviour
{
    float timeAfterDeath;
    [SerializeField] GameObject DeathMenu;
    bool setTimeSpeedNormal = false;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterDeath = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterDeath += Time.deltaTime;
        if(timeAfterDeath >= 4.5f)
        {
            if(!setTimeSpeedNormal)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        DeathMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
        setTimeSpeedNormal = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1.0f;
        setTimeSpeedNormal = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
