using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class WaitWhite : MonoBehaviour
{
    private White White;

    private void Start()

    {
        White = FindAnyObjectByType<White>();
    }
    private void OnDestroy()
    {
        White.Stop = true;
    }


}