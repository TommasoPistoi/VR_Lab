using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class DestroyGreen : MonoBehaviour
{
    private Yellow Yellow;

    private void Start()

    {
        Yellow = FindAnyObjectByType<Yellow>();
    }
    private void OnDestroy()
    {
        Yellow.Stop = true;
    }


}