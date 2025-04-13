using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
public class White : MonoBehaviour
{
    public GameObject Palla;
    public GameObject EffectWeak;
    public GameObject EffectStrong;
    public float Rotation;
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

        if (Inputtesting.Test_Spell)
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