using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class SpawnEnemyManager : MonoBehaviour
{
    public static SpawnEnemyManager instance { get; set; }
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;
    public List<GameObject> allEnemy = new List<GameObject>();
    private float start = 0f;
    private float spawn = 5f;
    public bool isActive = true;
    
    private void Start()
    {
        var newEnemy = Instantiate(enemy, transform.position, quaternion.identity);
        newEnemy.GetComponent<EnemyAttack>().setPlayer(player);
    }

    // Update is called once per frame
    void Update()
    {
        start += Time.deltaTime;
        if (isActive)
        {
            if (start>= spawn)
            {
                if (allEnemy.Count < 6)
                {
                    var newEnemy = Instantiate(enemy, transform.position, quaternion.identity);
                    newEnemy.GetComponent<EnemyAttack>().setPlayer(player);
                }
                start = 0f;
            }
        }
    }
}
