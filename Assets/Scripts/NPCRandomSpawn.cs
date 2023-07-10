using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomSpawn : MonoBehaviour
{
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> enemyPrefabs = new List<GameObject>();
    public int amountEnemies = 20;

    private void Start()
    {
        SpawnEnemies();
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < amountEnemies; i++)
        {
            Transform spawnPoint = GetRandomSpawnPoint();
            GameObject enemy = SpawnEnemy(spawnPoint);
        }
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
