using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject[] cubePrefab;
    public GameObject player;

    private Vector3 playerSpawnPosition = new Vector3(0, 0, 0);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RespawnPlayer();
        }
    }
    private void Awake()
    {
        RedCubeStartPosition();
        GreenCubeStartPosition();
        BlueCubeStartPosition();
    }
    public void RespawnPlayer()
    {
        player.SetActive(false);
        player.transform.position = playerSpawnPosition;
        player.SetActive(true);
    }

    public void RedCubeStartPosition()
    {
        cubePrefab[0].gameObject.transform.position = new Vector3(0, 1, 3);
    }
    public void GreenCubeStartPosition()
    {
        
        cubePrefab[1].gameObject.transform.position = new Vector3(1, 1, 3);

    }
    public void BlueCubeStartPosition()
    {
        cubePrefab[2].gameObject.transform.position = new Vector3(2, 1, 3);
        
    }
}
