using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject npcPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(npcPrefab, gameObject.transform.position, Quaternion.identity);
        }
        
    }
}
