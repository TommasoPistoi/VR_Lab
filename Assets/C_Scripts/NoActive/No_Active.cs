using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class DestroyFire : MonoBehaviour
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