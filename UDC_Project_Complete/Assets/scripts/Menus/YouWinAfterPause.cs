using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinAfterPause : MonoBehaviour
{
    float pauseTime;
    [SerializeField] GameObject WinPanel;

    // Start is called before the first frame update
    void Start()
    {
        pauseTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseTime >= 2.0f)
        {
            WinPanel.SetActive(true);
        }

        pauseTime += Time.deltaTime;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
    }

    public void Quit()
    {
        Application.Quit();
    }
}
