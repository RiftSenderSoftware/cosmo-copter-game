using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneZone : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
