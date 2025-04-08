using JetBrains.Annotations;
using UnityEngine;

public class Example : MonoBehaviour
{
    private float speed = 2f;
    public GameObject Palla;
    public GameObject Effect;
    private inputtesting Inputtesting;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
    }


    private void OnTriggerEnter(Collider Palla)
    {
        if (Palla.CompareTag("Left"))
        {

            Effect.SetActive(true);
        }


    }
}




       
