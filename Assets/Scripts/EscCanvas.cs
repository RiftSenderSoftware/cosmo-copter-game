using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;

public class EscCanvas : MonoBehaviour
{
    public GameObject[] allCanvas;
    public bool escapeMenu;

    public GameObject Hands;
    public FirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escapeInput();
        }
       
    }

    public void escapeInput()
    {
        if (escapeMenu == false)
        {
            allCanvas[0].SetActive(false);
            allCanvas[1].SetActive(true);

            PauseGame();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Hands.SetActive(false);
            fpc.enabled = false;

            Debug.Log("Paused");
            escapeMenu = true;


        }
        else
        {
            allCanvas[1].SetActive(false);
            allCanvas[0].SetActive(true);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Hands.SetActive(true);
            fpc.enabled = true;

            Debug.Log("Not Paused");
            escapeMenu = false;

            Time.timeScale = 1f;
        }
        
    }

    public void OffAllCanvas()
    {
        for(int i = 0; i < allCanvas.Length; i++) { allCanvas[i].SetActive(false); }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
    }
}
