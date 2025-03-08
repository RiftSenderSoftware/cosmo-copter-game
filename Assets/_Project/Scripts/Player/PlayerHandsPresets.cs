using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandsPresets : MonoBehaviour
{

    public GameObject[] eventActivator;
    public GameObject[] additionalElements;

    public Inventory invScript;

    // Start is called before the first frame update
    void Start()
    {
        clearAllHandsElements();
    }

    // Update is called once per frame
    void Update()
    {
        
        if 
        (  Input.GetKeyDown(KeyCode.Alpha1) || 
           Input.GetKeyDown(KeyCode.Alpha2) || 
           Input.GetKeyDown(KeyCode.Alpha3) || 
           Input.GetKeyDown(KeyCode.Alpha4) ||
           Input.GetKeyDown(KeyCode.Alpha5))
        {
            clearAllHandsElements();
            // Кулаки
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // присваивает инвентарной сетке значение
                invScript.coutPlace = 0;
            }
            // Динамит
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                invScript.coutPlace = 1;

                eventActivator[0].SetActive(true);
                additionalElements[0].SetActive(true);
            }
            // тестовый чел
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                invScript.coutPlace = 2;

                eventActivator[1].SetActive(true);
                additionalElements[1].SetActive(true);
            }
            // 
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                invScript.coutPlace = 3;

                eventActivator[2].SetActive(true);
                additionalElements[2].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                invScript.coutPlace = 4;

                eventActivator[3].SetActive(true);
                additionalElements[3].SetActive(true);
            }
        }
        
    }

    public void clearAllHandsElements()
    {

        eventActivator[0].SetActive(false);
        additionalElements[0].SetActive(false);

        eventActivator[1].SetActive(false);
        additionalElements[1].SetActive(false);

        eventActivator[2].SetActive(false);
        additionalElements[2].SetActive(false);

        eventActivator[3].SetActive(false);
        additionalElements[3].SetActive(false);
    }
}
