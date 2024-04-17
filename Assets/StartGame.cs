using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        enemy.SetActive(true);
    }
}
