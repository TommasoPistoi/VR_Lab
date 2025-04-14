using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

public class Water : MonoBehaviour
{
    public GameObject Palla;
    public GameObject EffectWeak;
    public GameObject EffectStrong;
    public GameObject SpawnPosition;
    public float Rotation;
    private inputtesting Inputtesting;
    public GameObject SpawnWaiting;
    public GameObject EffectWaiting;
    public bool CastingSpell;
    public bool Stop;

private void Start()
{
    Inputtesting = FindAnyObjectByType<inputtesting>();
    Stop = true;
}

void Update()
{

    if (Inputtesting.Pollice_Right_bool)
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