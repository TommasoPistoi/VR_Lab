using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    public GameObject Palla;
    public float Rotation;
    public GameObject EffectWeak;
    public GameObject EffectStrong;
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

        if (Inputtesting.Trigger_Right_bool)
        {
            if (Stop == true)
            {

                Quaternion customRotation = Quaternion.Euler(0f, Rotation, 0f);

                Instantiate(EffectWeak, SpawnPosition.transform.position, customRotation);
                Stop = false;
            }


        }
    }
}


