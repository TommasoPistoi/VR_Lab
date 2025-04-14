using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

public class EnemieSpawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> Enemies = new List<GameObject>(); // Lista dei prefab dei nemici
    public float spawnInterval = 2f; // Intervallo di tempo tra una spawn e l'altra (in secondi)
    public int maxEnemies = 15; // Numero massimo di nemici attivi contemporaneamente
    public GameObject Target; // Il target verso cui i nemici si muoveranno

    private int currentEnemies = 0; // Numero corrente di nemici attivi

    void Start()
    {
        StartCoroutine(SpawnEnemies()); // Inizia la coroutine di spawn
    }

    IEnumerator SpawnEnemies()
    {
        while (true) // Loop infinito per la spawn
        {
            if (currentEnemies < maxEnemies && Enemies.Count > 0 && Target != null) // Controlla se si può spawnare
            {
                Vector3 spawnPosition = transform.position; // Posizione di spawn (usa la posizione dello spawner)
                Quaternion spawnRotation = Quaternion.identity; // Rotazione di spawn (nessuna rotazione)
                GameObject newEnemy = Instantiate(Enemies[Random.Range(0, Enemies.Count)], spawnPosition, spawnRotation); // Istanzia un nemico casuale
                if (newEnemy != null)
                {
                    // Assicura che il nemico abbia lo script di movimento
                    EnemyMovement enemyMovement = newEnemy.GetComponent<EnemyMovement>();
                    if (enemyMovement == null)
                    {
                        enemyMovement = newEnemy.AddComponent<EnemyMovement>(); // Aggiunge lo script se non esiste
                    }
                    enemyMovement.target = Target; // Imposta il target nello script di movimento
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


