using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class ChangeTarget : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    private void OnTriggerEnter(Collider other)
    {
        enemy.GetComponent<AIMove>().focusPlayer = true;
    }
}
