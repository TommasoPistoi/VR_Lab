using UnityEngine;

public class SfereRotation : MonoBehaviour
{
    public GameObject[] objectsToRotate; // Array di oggetti da ruotare
    public float rotationAngle = 40f; // Angolo di rotazione
    private inputtesting inputtesting;
    private Yellow Yellow;
    private White White;
    private Water Water;
    private Purple Purple;
    private Example Fire;
    public GameObject LeftButton;
    public GameObject RightButton;

    void Start()
    {
        inputtesting = FindAnyObjectByType<inputtesting>();
        Yellow = FindAnyObjectByType<Yellow>();
        White = FindAnyObjectByType<White>();
        Water = FindAnyObjectByType<Water>();
        Purple = FindAnyObjectByType<Purple>();
        Fire = FindAnyObjectByType<Example>();
    }

    void Update()
    {
        //Controlla se un pulsante è premuto
        /*if (inputtesting.Indice_Left_bool)
        {
            RotateObjects(-rotationAngle);
            Yellow.Rotation = Yellow.Rotation - 30;
            White.Rotation = White.Rotation - 30;
            Water.Rotation = Water.Rotation - 30;
            Purple.Rotation = Purple.Rotation - 30;
            Fire.RotationWeak = Fire.RotationWeak - 30;


            Yellow.RotationStrong = Yellow.RotationStrong - 70;
            White.RotationStrong = White.RotationStrong - 70;
            Water.RotationStrong = Water.RotationStrong - 70;
            Purple.RotationStrong = Purple.RotationStrong - 70;
            Fire.RotationStrong = Fire.RotationStrong - 70;
        }
        else if (inputtesting.Indice_Right_bool)
        {
            RotateObjects(rotationAngle);
            Yellow.Rotation = Yellow.Rotation + 30;
            White.Rotation = White.Rotation + 30;
            Water.Rotation = Water.Rotation + 30;
            Purple.Rotation = Purple.Rotation + 30;
            Fire.RotationWeak = Fire.RotationWeak + 30;


            Yellow.RotationStrong = Yellow.RotationStrong + 70;
            White.RotationStrong = White.RotationStrong + 70;
            Water.RotationStrong = Water.RotationStrong + 70;
            Purple.RotationStrong = Purple.RotationStrong + 70;
            Fire.RotationStrong = Fire.RotationStrong + 70;
        }*/
    }

    public void LeftButtonCalled(){
        RotateObjects(rotationAngle);
        Yellow.Rotation = Yellow.Rotation + 30;
        White.Rotation = White.Rotation + 30;
        Water.Rotation = Water.Rotation + 30;
        Purple.Rotation = Purple.Rotation + 30;
        Fire.RotationWeak = Fire.RotationWeak + 30;


        Yellow.RotationStrong = Yellow.RotationStrong + 70;
        White.RotationStrong = White.RotationStrong + 70;
        Water.RotationStrong = Water.RotationStrong + 70;
        Purple.RotationStrong = Purple.RotationStrong + 70;
        Fire.RotationStrong = Fire.RotationStrong + 70;
    }

    public void RightButtonCalled(){
        RotateObjects(-rotationAngle);
        Yellow.Rotation = Yellow.Rotation - 30;
        White.Rotation = White.Rotation - 30;
        Water.Rotation = Water.Rotation - 30;
        Purple.Rotation = Purple.Rotation - 30;
        Fire.RotationWeak = Fire.RotationWeak - 30;


        Yellow.RotationStrong = Yellow.RotationStrong - 70;
        White.RotationStrong = White.RotationStrong - 70;
        Water.RotationStrong = Water.RotationStrong - 70;
        Purple.RotationStrong = Purple.RotationStrong - 70;
        Fire.RotationStrong = Fire.RotationStrong - 70;
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

