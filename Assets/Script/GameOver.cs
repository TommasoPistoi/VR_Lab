using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour
{
    public Collider target; // Il collider del giocatore (assegnato dall'inspector)
    public GameObject gameOverUI; // L'UI del game over (assegnato dall'inspector)
    [SerializeField] public List<string> EnemyTags = new List<string>();

    private void Start()
    {
        // Assicurati che l'UI del game over sia disattivato all'inizio
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
    }

   // Questo metodo viene chiamato quando un altro collider entra in contatto con il collider del giocatore
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i<EnemyTags.Count; i++)
        {
            Debug.Log("I got you");
            if (target.gameObject.CompareTag(EnemyTags[i])) 
            { 
                 if (gameOverUI != null)
                {
                    gameOverUI.SetActive(true);
                }
                    return;
            }
        }
    }

    // Metodo per gestire il game over
    public void Lost()
    {
        Debug.Log("Game Over!");
    }
}
