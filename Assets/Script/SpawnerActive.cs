using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class SpawnerActive : MonoBehaviour
{
    public GameObject spawner;
    public bool isActive = true;

    private void Start()
    {
        
    }

    private void Update()
    {
       
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            spawner.SetActive(true);
            isActive = true;
        }
    }
}
