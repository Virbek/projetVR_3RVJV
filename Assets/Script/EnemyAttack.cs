using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAttack : MonoBehaviour
{
    [SerializeField]private NavMeshAgent agent;
    private GameObject _player;

    private void Start()
    {
        SpawnEnemyManager.instance.allEnemy.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(_player.transform.position);
    }

    private void OnDestroy()
    {
        SpawnEnemyManager.instance.allEnemy.Remove(gameObject);
    }

    public void setPlayer(GameObject truePlayer)
    {
        _player = truePlayer;
    }
}
