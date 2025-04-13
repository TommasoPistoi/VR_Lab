using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class Purple : MonoBehaviour
{
    public GameObject Palla;
    public GameObject EffectWeak;
    public GameObject EffectStrong;
    public GameObject SpawnPosition;
    private inputtesting Inputtesting;
    public float Rotation;
    public bool Stop;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
        Stop = true;
    }

    void Update()
    {

        if (Inputtesting.Pollice_Left_bool)
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
