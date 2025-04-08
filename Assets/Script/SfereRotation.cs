using UnityEngine;

public class SfereRotation : MonoBehaviour
{
    public float degreesPerSecond = 90f; // Velocità di rotazione in gradi al secondo
    public Vector3 rotationAxis = Vector3.up; // Asse di rotazione (default: asse Y)
    private bool isRotating = false; // Variabile per controllare la rotazione
    private inputtesting inputtesting;


    void Start()
    {
        inputtesting = FindAnyObjectByType<inputtesting>();
    }

    void Update()
    {
        if (inputtesting.Indice_Right_bool) // Controlla se il tasto 'P' è premuto
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

