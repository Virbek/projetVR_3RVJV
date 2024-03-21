using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField] private Transform[] target;

    private int index = 0;

    private void Start()
    {
        agent.SetDestination((target[index].position));
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination((target[index].position));
        var dist = Vector3.Distance(target[index].transform.position,transform.position);
        if (dist < 2)
        {
            index++;
        }
    }
}
