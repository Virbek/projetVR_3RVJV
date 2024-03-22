using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGate : MonoBehaviour
{
	public float speed;
	public Transform openedPosition;
	public Transform gate;

    // Start is called before the first frame update
    
    public void OpenDoor()
    {
	    gate.position = openedPosition.position;
    }
    
    
}
