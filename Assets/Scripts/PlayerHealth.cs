using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float healthMAX = 100;

    public TextMeshProUGUI healthText;

    public AudioSource panch;


    private void Start()
    {
            healthText.text = "Health: " + health;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPCHandFight"))
        {
            health -= 30;
            healthText.text = "Health: " + health;
            //panch.Play();
            Debug.Log(health);
        }
    }
}
