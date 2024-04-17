using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEnemies : MonoBehaviour
{
    [SerializeField] private GameObject spawner;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (var enemy in SpawnManager.instance.allEnemy)
            {
                Destroy(enemy);
            }
           spawner.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawner.gameObject.SetActive(true);
        }
    }
}
