using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerDinamiteSpawn : MonoBehaviour
{
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> enemyPrefabs = new List<GameObject>();
    public float speed = 200;
    public int amountEnemies = 1;
    // Start is called before the first frame update
    void Start()
    {
       // LeftHandDinamite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SpawnDinamite();
        }
    }

    public void SpawnDinamite()
    {
        for (int i = 0; i < amountEnemies; i++)
        {
            Transform spawnPoint = GetRandomSpawnPoint();
            GameObject item = SpawnEnemy(spawnPoint);
            item.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * speed, ForceMode.Impulse);

        }
    }

    public void LeftHandDinamite()
    {
        Transform spawnPoint = GetRandomSpawnPoint();
        GameObject item = SpawnEnemy(spawnPoint);
        
        item.GetComponent<Rigidbody>().isKinematic = true;
    }

    private Transform GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Count)];
    }

    private GameObject SpawnEnemy(Transform spawnPoint)
    {
        // —юда можно дописать использование пула дл€ врагов или более сложный алгоритм выбора противника
        var prefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
        return Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        
    }
}
