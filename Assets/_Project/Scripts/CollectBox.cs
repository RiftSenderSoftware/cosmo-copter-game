using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectBox : MonoBehaviour
{
    public Counter counter;
    public Spawner spawnCubes;

    private void OnTriggerEnter(Collider other)
    {
        CubeCollect(other,"RedCube");
        CubeCollect(other,"GreenCube");
        CubeCollect(other,"BlueCube");
    }

    private void CubeCollect(Collider other, string nameTag)
    {
        if (other.gameObject.tag == nameTag)
        {
            if(gameObject.name == "RedCollectZone" && nameTag == "RedCube")
            {
                counter.coutChange = counter.coutChange - 1;
                other.gameObject.SetActive(false);
            }
            else
            {
                spawnCubes.RedCubeStartPosition();
            }

            if (gameObject.name == "GreenCollectZone" && nameTag == "GreenCube")
            {
                counter.coutChange = counter.coutChange  - 1;
                other.gameObject.SetActive(false);
            }
            else
            {
                spawnCubes.GreenCubeStartPosition();
            }

            if (gameObject.name == "BlueCollectZone" && nameTag == "BlueCube")
            {
                counter.coutChange = counter.coutChange - 1;
                spawnCubes.BlueCubeStartPosition();
            }
            else
            {
                Debug.Log("Cube respawn");
            }
        }
    }
}
