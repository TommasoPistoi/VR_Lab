using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class WaitDark : MonoBehaviour
{
    private Purple Purple;

    private void Start()

    {
        Purple = FindAnyObjectByType<Purple>();
    }
    private void OnDestroy()
    {
        Purple.Stop = true;
    }


}