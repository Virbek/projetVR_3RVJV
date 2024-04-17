using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEnemies : MonoBehaviour
{
    [SerializeField] private List<GameObject> allSpawner = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (var s in allSpawner)
            {
                s.GetComponent<SpawnEnemyManager>().allEnemy.Clear();
                s.GetComponent<SpawnEnemyManager>().isActive = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (var s in allSpawner)
            {
                s.GetComponent<SpawnEnemyManager>().isActive = true;
            }
        }
    }
}
