using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class WaitRed : MonoBehaviour
{
    private Example Fire;

    private void Start()

    {
        Fire = FindAnyObjectByType<Example>();
    }
    private void OnDestroy()
    {
        Fire.Stop = true;
    }


}