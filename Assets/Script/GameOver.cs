using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour
{
    public int maxLives = 3; // Numero massimo di vite
    private int currentLives; // Vite correnti
    public GameObject gameOverScreen; // Riferimento al pannello di Game Over

    void Start()
    {
        currentLives = maxLives; // Inizializza le vite all'inizio
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(false); // Assicurati che il pannello di Game Over sia disattivato all'inizio
        }
    }

    public void TakeDamage()
    {
        currentLives--; // Riduci le vite

        Debug.Log("Vite rimanenti: " + currentLives); // Mostra le vite rimanenti in console

        if (currentLives <= 0)
        {
            Lost(); // Chiama la funzione GameOver se le vite sono esaurite
        }
    }

    private void Lost()
    {
        Debug.Log("Game Over!"); // Messaggio di Game Over in console

        // Attiva il pannello di Game Over (se presente)
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }

        // Puoi aggiungere altre azioni di Game Over qui, come:
        // - Disattivare il target
        // - Bloccare i controlli del giocatore
        // - Caricare una scena di Game Over
    }
}


