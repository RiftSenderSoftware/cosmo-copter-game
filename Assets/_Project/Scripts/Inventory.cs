using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

public class Inventory : MonoBehaviour
{
    public int coutPlace;
    private int lastCoutPlace;
    public GameObject[] allPlaces;
    public TextMeshProUGUI descriptionPlaces;
    public GameObject background;
    private void Start()
    {
        descriptionUpdate();
    }
    private void Update()
    {
        if (coutPlace != lastCoutPlace)
        {
            lastCoutPlace = coutPlace;
            background.transform.position = allPlaces[coutPlace].transform.position;

            descriptionUpdate();
        }
    }

    public void descriptionUpdate()
    {
        if (coutPlace == 0) { descriptionPlaces.text = "LMB - Left hand HIT \nRMB - Right hand HIT"; }
        if (coutPlace == 1) { descriptionPlaces.text = "LMB - Dinamite RAIN \nRMB - Dinamite ACTIVATE"; }
        if (coutPlace == 2) { descriptionPlaces.text = "LMB - HiMan RAIN \nRMB - Forward HIMAN!"; }
        if (coutPlace == 3) { descriptionPlaces.text = "LMB - Water FIRE \nRMB - Forward WATER!"; }
        if (coutPlace == 4) { descriptionPlaces.text = "LMB - Gun FIRE \nRMB - Forward GUN!"; }
    }

}
