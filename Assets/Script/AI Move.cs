using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Samples;
using UnityEngine;
using UnityEngine.AI;


public class AIMove : MonoBehaviour
{
    public FieldOfView fieldOfView;
    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField] private Transform[] target;
    
    [SerializeField]
    private Transform spawn;
    [SerializeField]
    private Transform spawnHammer;

    public bool focusPlayer = false;


    [SerializeField] private GameObject player;
    [SerializeField] private GameObject hammer;

    private int _index = 0;

    private void Start()
    {
        agent.SetDestination((target[_index].position));
    }

    // Update is called once per frame
    void Update()
    {
        if (focusPlayer)
        {
            agent.SetDestination(player.transform.position);
            var distPlayer = Vector3.Distance(player.transform.position,transform.position);
            if (distPlayer < 2)
            {
                focusPlayer = false;
                player.transform.position = spawn.position;
                hammer.transform.position = spawnHammer.position;
            } 
        }
        else
        {
            agent.SetDestination((target[_index].position));
            var dist = Vector3.Distance(target[_index].transform.position,transform.position);
            if (dist < 2)
            {
                _index++;
                if (_index >= 5)
                {
                    _index = 0;
                }
            }
        
            //Détection du joueur
            if (fieldOfView.Detect(transform, player))
            {
                agent.SetDestination(player.transform.position);
            }
        
            var distPlayer = Vector3.Distance(player.transform.position,transform.position);
            if (distPlayer < 2)
            {
                player.transform.position = spawn.position;
                hammer.transform.position = spawnHammer.position;
            } 
        }
        
    }
}
