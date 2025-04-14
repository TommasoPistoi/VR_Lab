using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class WaitBlu : MonoBehaviour
{
    private Water Water;

    private void Start()

    {
        Water = FindAnyObjectByType<Water>();
    }
    private void OnDestroy()
    {
        Water.Stop = true;
    }


}