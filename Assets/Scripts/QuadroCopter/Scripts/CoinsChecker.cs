using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class CoinsChecker : MonoBehaviour
{
    public int coins = 0;
    public int coinsChecker = 0;

    public TextMeshProUGUI uGUI;

    // Start is called before the first frame update
    void Start()
    {
        uGUI.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(coins != coinsChecker)
        {
            coins = coinsChecker;
            uGUI.text = coins.ToString();

        }
    }

    public void Check()
    {
        coinsChecker += 1;
    }
}
