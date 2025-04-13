using UnityEngine;

public class SfereRotation : MonoBehaviour
{
    public GameObject[] objectsToRotate; // Array di oggetti da ruotare
    public float rotationAngle = 40f; // Angolo di rotazione
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
        if (inputtesting.Indice_Left_bool)
        {
            RotateObjects(-rotationAngle);
        }
        else if (inputtesting.Indice_Right_bool)
        {
            RotateObjects(rotationAngle);
        }
    }

    public void LeftButtonCalled(){
        RotateObjects(rotationAngle);
    }

    public void RightButtonCalled(){
        RotateObjects(-rotationAngle);
    }


    void RotateObjects(float angle)
    {
        Vector3 Up=new Vector3(0,1,0);
        foreach (GameObject obj in objectsToRotate)
        {
            if (obj != null)
            {
                obj.transform.Rotate(Up, angle);
            }
        }
    }
}

