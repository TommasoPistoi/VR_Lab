using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameOver gameOver;
    public float speed = 3f; // Velocità di movimento del nemico
    public GameObject Target; // Il target verso cui muoversi

    void Update()
    {
        if (Target != null)
        {
            // Calcola la direzione verso il target
            Vector3 direction = Target.transform.position - transform.position;

            // Muove il nemico verso il target
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }

    // Metodo per la distruzione del nemico (opzionale)
    [System.Obsolete]
    public void DestroyEnemy()
    {
        Destroy(gameObject);
        // Chiama il metodo EnemyDestroyed() nello spawner
        EnemieSpawner spawner = FindObjectOfType<EnemieSpawner>();
        if (spawner != null)
        {
            spawner.EnemyDestroyed();
        }
    }

    // Metodo per gestire le collisioni (opzionale)
    [System.Obsolete]
    void OnCollisionEnter(Collision collision)
    {
        // Esempio: distrugge il nemico se colpisce qualcosa con il tag "Obstacle"
        if (collision.gameObject.CompareTag("Target"))
        {
            gameOver = collision.transform.gameObject.GetComponent<GameOver>();
            gameOver.TakeDamage();
        }
    }
}

