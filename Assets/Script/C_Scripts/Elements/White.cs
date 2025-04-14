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
    public GameObject SpawnWaiting;
    public GameObject EffectWaiting;
    public bool CastingSpell;
    public bool Cast_Strong_Spell;
    public GameObject StrongSpell;
    public float RotationStrong;
    public GameObject SpawnStrong;

    private void Start()
    {
        Inputtesting = FindAnyObjectByType<inputtesting>();
        Stop = false;
        CastingSpell = false;
    }

    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.F)))
        {
            if (CastingSpell == true)
            {
                Cast_Strong_Spell = true;
                CastingSpell = false;
            }

        }
        if (Inputtesting.Test_Spell)
        {
            if (CastingSpell == false)
            {
                Instantiate(EffectWaiting, SpawnWaiting.transform.position, SpawnPosition.transform.rotation);
                CastingSpell = true;
            }

        }
        if (Stop == true)
        {
            if (CastingSpell == true)
            {
                Quaternion customRotation = Quaternion.Euler(0f, Rotation, 0f);
                Instantiate(EffectWeak, SpawnPosition.transform.position, customRotation);
                Stop = false;
                CastingSpell = false;

            }
            if (Cast_Strong_Spell == true)
            {
                Quaternion customRotation = Quaternion.Euler(0f, RotationStrong, 0f);
                Instantiate(StrongSpell, SpawnStrong.transform.position, customRotation);
                Cast_Strong_Spell = false;
                CastingSpell = false;
                Stop = false;

            }
        }
    }
}
