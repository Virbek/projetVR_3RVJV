using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIMove : MonoBehaviour
{
    public FieldOfView fieldOfView;
    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField] private Transform[] target;

    [SerializeField] private GameObject player;

    private int _index = 0;

    private void Start()
    {
        agent.SetDestination((target[_index].position));
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination((target[_index].position));
        var dist = Vector3.Distance(target[_index].transform.position,transform.position);
        if (dist < 2)
        {
            _index++;
            if (_index == 5)
            {
                _index = 0;
            }
        }
        
        //Détection du joueur
        if (fieldOfView.Detect(transform, player))
        {
            agent.SetDestination(player.transform.position);
        }
    }
}
