using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]private NavMeshAgent agent;
    private GameObject player;

    private void Start()
    {
        SpawnEnemyManager.instance.allEnemy.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        var distPlayer = Vector3.Distance(player.transform.position,transform.position);
        if (distPlayer < 2)
        {
            SceneManager.LoadScene("Niveau 1");
        }
    }

    private void OnDestroy()
    {
        SpawnEnemyManager.instance.allEnemy.Remove(gameObject);
    }

    public void setPlayer(GameObject truePlayer)
    {
        player = truePlayer;
    }
}
