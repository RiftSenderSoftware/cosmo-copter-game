using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void PauseExit()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void PauseMenuExit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
