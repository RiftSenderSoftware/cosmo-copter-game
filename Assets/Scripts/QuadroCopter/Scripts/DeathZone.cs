using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            QuadroInput qi = other.GetComponent<QuadroInput>();
            qi.PlayerDead();
            Debug.Log("death");
        }
    }
}
