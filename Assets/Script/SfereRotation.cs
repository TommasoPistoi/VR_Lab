using UnityEngine;

public class SfereRotation : MonoBehaviour
{
    public float degreesPerSecond = 90f; // Velocità di rotazione in gradi al secondo
    public Vector3 rotationAxis = Vector3.up; // Asse di rotazione (default: asse Y)
    private bool isRotating = false; // Variabile per controllare la rotazione

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // Controlla se il tasto 'P' è premuto
        {
            isRotating = !isRotating; // Inverte lo stato di rotazione
        }

        if (isRotating)
        {
            // Calcola la rotazione in base al tempo trascorso
            float rotationAmount = degreesPerSecond * Time.deltaTime;

            // Applica la rotazione all'oggetto
            transform.Rotate(rotationAxis, rotationAmount);
        }
    }
}

