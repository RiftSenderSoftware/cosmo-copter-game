using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            RestartPreset();
        }
    }

    public void RestartPreset()
    {
        YandexGame.FullscreenShow();

        if (gameObject.name == "FinishLevel1")
        {
            SceneManager.LoadScene(1);
        }
        if (gameObject.name == "FinishLevel2")
        {
            SceneManager.LoadScene(2);
        }
        if (gameObject.name == "FinishLevel3")
        {
            SceneManager.LoadScene(3);
        }
        if (gameObject.name == "FinishLevel4")
        {
            SceneManager.LoadScene(4);
        }
        if (gameObject.name == "FinishLevel5")
        {
            SceneManager.LoadScene(5);
        }
        if (gameObject.name == "FinishSandboxLevel")
        {
            SceneManager.LoadScene(7);
        }
    }
}
