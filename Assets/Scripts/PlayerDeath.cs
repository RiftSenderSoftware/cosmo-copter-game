using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerDeath : MonoBehaviour
{
    public PlayerHealth playerHP;

    public GameObject Hands;
    public FirstPersonController fpc;

    public GameObject PlauerUI;
    public GameObject DeathUI;


    // Update is called once per frame
    void Update()
    {
        if(playerHP.health <= 0)
        {
            if (PlauerUI.activeSelf == true)
            {
                PauseGame();

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                Hands.SetActive(false);
                fpc.enabled = false;

                PlauerUI.SetActive(false);
                DeathUI.SetActive(true);
            }
            
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
    }
}
