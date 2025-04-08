using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject Palla;
    public GameObject Effect;
    public GameObject SpawnPosition;
    private inputtesting Inputtesting;
    public bool Stop;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
        Stop = true;
    }

    void Update()
    {

        if (Inputtesting.Trigger_Left_bool)
        {
            if (Stop == true)
            {

                Instantiate(Effect, SpawnPosition.transform.position, Quaternion.identity);
                Stop = false;
            }


        }
    }
}
