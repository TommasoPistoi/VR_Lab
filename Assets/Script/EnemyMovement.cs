using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject target; // L'obiettivo verso cui il nemico si muove
    public float speed = 5f; // Velocità di movimento del nemico

    void Update()
    {
        // Controlla se l'obiettivo è assegnato
        if (target != null)
        {
            // Calcola la direzione verso l'obiettivo
            Vector3 direction = (target.transform.position).normalized;

            // Muovi il nemico nella direzione calcolata
            transform.position += speed * Time.deltaTime * direction;
        }
    }
}

