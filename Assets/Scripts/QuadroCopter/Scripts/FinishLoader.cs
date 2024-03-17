using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class FinishLoader : MonoBehaviour
{
    public GameObject finishMessege;
    public GameObject continueMessegeNExt;
    public GameObject continueMessegeReset;
    public GameObject continueMessegeExit;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            finishMessege.SetActive(true);
        }
        
    }
    public void NextLevel()
    {
        YandexGame.FullscreenShow();
        Time.timeScale = 0f;
        continueMessegeNExt.SetActive(true);
    }
    public void RestartLevel()
    {
        YandexGame.FullscreenShow();
        Time.timeScale = 0f;

        continueMessegeReset.SetActive(true);
        
    }
    public void ExitMenu()
    {
        YandexGame.FullscreenShow();
        Time.timeScale = 0f;

        continueMessegeExit.SetActive(true);
    }

    public void ContinueBtn()
    {
        Time.timeScale = 1f;

        if (gameObject.name == "FinishLevel1")
        {
            SceneManager.LoadScene(2);
        }
        if (gameObject.name == "FinishLevel2")
        {
            SceneManager.LoadScene(3);
        }
        if (gameObject.name == "FinishLevel3")
        {
            SceneManager.LoadScene(4);
        }
        if (gameObject.name == "FinishLevel4")
        {
            SceneManager.LoadScene(5);
        }
        if (gameObject.name == "FinishLevel5")
        {
            SceneManager.LoadScene(6);
        }
        if (gameObject.name == "FinishSandboxLevel")
        {
            SceneManager.LoadScene(0);
        }
    }
    public void ResetBtn()
    {
        Time.timeScale = 1f;

        switch (gameObject.name)
        {
            case "FinishLevel1":
                SceneManager.LoadScene(1);
                break;
            case "FinishLevel2":
                SceneManager.LoadScene(2);
                break;
            case "FinishLevel3":
                SceneManager.LoadScene(3);
                break;
            case "FinishLevel4":
                SceneManager.LoadScene(4);
                break;
            case "FinishLevel5":
                SceneManager.LoadScene(5);
                break;
            case "FinishSandboxLevel":
                SceneManager.LoadScene(6);
                break;
        }
    }
    public void Exitbtn()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(0);

    }
}
