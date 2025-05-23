using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class EnemieSpawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> Enemies = new List<GameObject>(); // Lista dei prefab dei nemici
    public int spawnInterval; // Intervallo di tempo tra una spawn e l'altra (in secondi)
    public int maxEnemies = 15; // Numero massimo di nemici attivi contemporaneamente
    public GameObject Target; // Il target verso cui i nemici si muoveranno
    public float startSpawnDelay = 0f; // Ritardo prima di iniziare lo spawn (in secondi)

    private int currentEnemies = 0; // Numero corrente di nemici attivi

    void Start()
    {
        StartCoroutine(SpawnEnemies()); // Inizia la coroutine di spawn
    }

    IEnumerator SpawnEnemies()
    {
        // Attendi il ritardo prima di iniziare a spawnare
        yield return new WaitForSeconds(startSpawnDelay);

        while (true) // Loop infinito per la spawn
        {
            if (currentEnemies < maxEnemies && Enemies.Count > 0 && Target != null) // Controlla se si può spawnare
            {
                Vector3 spawnPosition = transform.position; // Posizione di spawn (usa la posizione dello spawner)
                GameObject newEnemy = Instantiate(Enemies[Random.Range(0, Enemies.Count)], transform.position, quaternion.identity); // Istanzia un nemico casuale
                if (newEnemy != null)
                {
                    // Assicura che il nemico abbia lo script di movimento
                    EnemyMovement enemyMovement = newEnemy.GetComponent<EnemyMovement>();
                    if (enemyMovement == null)
                    {
                        enemyMovement = newEnemy.AddComponent<EnemyMovement>(); // Aggiunge lo script se non esiste
                    }
                    enemyMovement.Target = Target; // Imposta il target nello script di movimento
                    currentEnemies++; // Incrementa il contatore dei nemici
                }
            }
            yield return new WaitForSeconds(spawnInterval); // Attende prima di spawnare di nuovo
        }
    }

    // Metodo per gestire la distruzione di un nemico
    public void EnemyDestroyed()
    {
        currentEnemies--; // Decrementa il contatore dei nemici
    }
}


