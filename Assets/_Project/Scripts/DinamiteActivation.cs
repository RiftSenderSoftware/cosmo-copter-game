using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamiteActivation : MonoBehaviour
{
    GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Dinamite");
        Debug.Log(obj.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            
            obj = GameObject.FindGameObjectsWithTag("Dinamite");
            Debug.Log(obj.Length);
            if(obj.Length != 0) 
            {
                obj[obj.Length - 1].GetComponent<Explosion>().active = true;
            }
            
        }
    }
}
