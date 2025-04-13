using System.Collections;
using UnityEngine;

public class EnemieSpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Il prefab del nemico da istanziare
    public float spawnInterval = 2f; // Intervallo di tempo tra una spawn e l'altra (in secondi)
    public float spawnRadius = 5f; // Raggio entro il quale i nemici verranno generati attorno al punto di spawn
    public int maxEnemies = 10; // Numero massimo di nemici attivi contemporaneamente

    private int currentEnemies = 0;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            if (currentEnemies < maxEnemies)
            {
                Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
                Quaternion spawnRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                Instantiate(enemyPrefab, spawnPosition, spawnRotation);
                currentEnemies++;
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Metodo per gestire la distruzione di un nemico
    public void EnemyDestroyed()
    {
        currentEnemies--;
    }
}

