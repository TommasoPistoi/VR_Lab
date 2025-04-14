using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Losing : MonoBehaviour
{
    [SerializeField] public List<string> EnemyTags = new List<string>();
    public GameObject lost;
   private void OnTriggerEnter (Collider collider)
   {
        for (int i = 0; i<EnemyTags.Count; i++)
        {
            if (collider.gameObject.tag == EnemyTags[i]) lost.SetActive(true);
            return;
        }
   }
}
