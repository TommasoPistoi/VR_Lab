using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using System.Collections.Generic;

public class GameOver : MonoBehaviour
{
    public GameObject player; // Il GameObject del giocatore (assegnato dall'inspector)
    public GameObject gameOverUI; // L'UI del game over (assegnato dall'inspector)
    [SerializeField] public List<string> EnemyTags = new List<string>(); // Lista dei tag dei nemici

    private void Start()
    {
        // Assicurati che l'UI del game over sia disattivato all'inizio
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
    }

    // Questo metodo viene chiamato quando un altro collider entra in contatto con il collider di questo GameObject
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called!"); // Verifica se il metodo viene chiamato
        Debug.Log("Collider triggered: " + other.gameObject.name); // Per debugging: mostra il nome dell'oggetto che ha attivato il trigger

        for (int i = 0; i < EnemyTags.Count; i++)
        {
            Debug.Log("Checking tag: " + EnemyTags[i]); // Per debugging: mostra il tag che stiamo controllando
            if (other.gameObject.CompareTag(EnemyTags[i])) // Controlla se l'oggetto ha uno dei tag dei nemici
            {
                Debug.Log("Game Over! Hit by: " + other.gameObject.name); // Messaggio di log per confermare il game over
                if (gameOverUI != null)
                {
                    gameOverUI.SetActive(true); // Attiva l'UI del game over
                }
                // Puoi aggiungere qui altre azioni di game over, come fermare il tempo, ecc.
                return; // Esci dalla funzione dopo aver attivato il game over
            }
        }
    }

    // Metodo per gestire il game over (opzionale, ma utile)
    public void RestartGame()
    {
        // Carica la scena corrente o una scena di game over
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        // oppure:  UnityEngine.SceneManagement.SceneManager.LoadScene("NomeDellaScenaGameOver");
    }
}

