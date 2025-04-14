using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class EnemieSpawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> Enemies = new List<GameObject>();
    public float spawnInterval = 2f; // Intervallo di tempo tra una spawn e l'altra (in secondi)
    
    public int maxEnemies = 15; // Numero massimo di nemici attivi contemporaneamente

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
                Vector3 spawnPosition = transform.position;
                Quaternion spawnRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                Instantiate(Enemies[Random.Range(0, Enemies.Count - 1)], spawnPosition, spawnRotation);
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

