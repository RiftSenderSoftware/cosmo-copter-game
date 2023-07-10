using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLoader : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player trigged finish collider. Collider Name:" + gameObject.name.ToString());
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
        
    }
}
