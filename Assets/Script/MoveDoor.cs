using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    
    public Transform openedPosition;
    public Transform closedPosition;
    public Transform door;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider obj) {
        
       OpenDoor();
       
    }

    void OnTriggerExit(Collider obj)
    {
        CloseDoor();
    }

    void OpenDoor()
    {
        door.position = openedPosition.position;
    }
    
    void CloseDoor()
    {
        
        door.position = closedPosition.position;

    }
}
