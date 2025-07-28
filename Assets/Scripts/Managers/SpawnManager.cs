using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] slimePrefabs;

    [Header("Settings")]
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float minX = -8f;
    [SerializeField] private float maxX = 8f;
    [SerializeField] private float spawnY = 6f;

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnSlime();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnSlime()
    {
        GameObject slimeToSpawn = slimePrefabs[Random.Range(0, slimePrefabs.Length)];
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);

        Instantiate(slimeToSpawn, spawnPosition, Quaternion.identity);
    }

}
