using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject Palla;
    public GameObject EffectWeak;
    public GameObject EffectStrong;
    public GameObject SpawnPosition;
    public float Rotation;
    private inputtesting Inputtesting;
    public bool Stop;
    public GameObject SpawnWaiting;
    public GameObject EffectWaiting;
    public bool CastingSpell;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
        Stop = true;
    }

    void Update()
    {

        if (Inputtesting.Trigger_Left_bool)
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
