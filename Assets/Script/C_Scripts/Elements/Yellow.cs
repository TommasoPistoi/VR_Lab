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
    public GameObject SpawnWaiting;
    public GameObject EffectWaiting;
    public bool CastingSpell;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
        Stop = false;
        CastingSpell = false;
    }

    void Update()
    {

        if (Inputtesting.Trigger_Right_bool)
        {

            Instantiate(EffectWaiting, SpawnWaiting.transform.position, SpawnPosition.transform.rotation);

        }

        if (Stop == true)
        {

            Quaternion customRotation = Quaternion.Euler(0f, Rotation, 0f);

            Instantiate(EffectWeak, SpawnPosition.transform.position, customRotation);
            Stop = false;
        }
    }

}


