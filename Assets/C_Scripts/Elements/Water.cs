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

            Instantiate(EffectWeak, SpawnPosition.transform.position, Quaternion.identity);
            Stop = false;
        }


    }
}
}