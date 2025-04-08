using UnityEngine;

public class SfereRotation : MonoBehaviour
{
    public GameObject[] objectsToRotate; // Array di oggetti da ruotare
    public float rotationAngle = 45f; // Angolo di rotazione
    private inputtesting inputtesting;
    public GameObject LeftButton;
    public GameObject RightButton;

    void Start()
    {
        inputtesting = FindAnyObjectByType<inputtesting>();
    }

    void Update()
    {
        //Controlla se un pulsante è premuto
        if (inputtesting.Indice_Right_bool == LeftButton)
        {
            RotateObjects(-rotationAngle);
        }
        else if (inputtesting.Indice_Right_bool == RightButton)
        {
            RotateObjects(rotationAngle);
        }
    }

    void RotateObjects(float angle)
    {
        foreach (GameObject obj in objectsToRotate)
        {
            if (obj != null)
            {
                obj.transform.Rotate(Vector3.forward, angle);
            }
        }
    }
}

