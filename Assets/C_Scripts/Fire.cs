using JetBrains.Annotations;
using UnityEngine;

public class Example : MonoBehaviour
{
    
    public GameObject Palla;
    public GameObject Effect;
    private inputtesting Inputtesting;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
    }


    private void OnTriggerEnter(Collider Palla)
    {
        if (Inputtesting.GetComponent<inputtesting>().Pollice_Left_bool == true)
        {
            Effect.SetActive(true);
        }


    }
}




       
