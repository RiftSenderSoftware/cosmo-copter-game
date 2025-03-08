using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;
 
    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }
}
