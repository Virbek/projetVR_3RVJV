using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class SpawnEnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;
    private float start = 0f;
    private float spawn = 5f;
    
    private void Start()
    {
        var newEnemy = Instantiate(enemy, transform.position, quaternion.identity);
        newEnemy.GetComponent<EnemyAttack>().setPlayer(player);
    }

    // Update is called once per frame
    void Update()
    {
        start += Time.deltaTime;
        if (start>= spawn)
        {
            if (SpawnManager.instance.allEnemy.Count < 6)
            {
                var newEnemy = Instantiate(enemy, transform.position, quaternion.identity);
                newEnemy.GetComponent<EnemyAttack>().setPlayer(player);
            }
            start = 0f;
        }
    }
}
