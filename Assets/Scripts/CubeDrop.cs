using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrop : MonoBehaviour
{
    public Spawner spawnCubes;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RedCube")
        {
            spawnCubes.RedCubeStartPosition();

        }
        if (other.gameObject.tag == "GreenCube")
        {
            spawnCubes.GreenCubeStartPosition();
            

        }
        if (other.gameObject.tag == "BlueCube")
        {
            spawnCubes.BlueCubeStartPosition();

        }
        if (other.gameObject.tag == "Player")
        {
            spawnCubes.RespawnPlayer();
            Debug.Log("ded zone trigger");
        }
        
    }
}
