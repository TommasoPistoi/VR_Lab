using System.Threading;
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


    void Update()
    {
        if (Inputtesting.GetComponent<inputtesting>().Trigger_Left_bool == true)
        {
            Effect.SetActive(true);
            Time 
        }
        

    }
}




       
