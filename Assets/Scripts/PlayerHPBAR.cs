using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBAR : MonoBehaviour
{
    public Image healthBar;
    public PlayerHealth playerHP;

    void Start()
    {
        
    }


    void Update()
    {
        healthBar.fillAmount = playerHP.health / playerHP.healthMAX;
    }
}
