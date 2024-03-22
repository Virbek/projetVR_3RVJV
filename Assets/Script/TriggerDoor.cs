using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	public float speed;
	public float maxOpenValue;
	
	public Transform door;
	public bool opening = false;
	public bool closing = false;

	[SerializeField] private GameObject player;

	private float currentValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if (opening) OpenDoor();
	    if (closing) CloseDoor();
    }
    
    void OnTriggerEnter(Collider obj) {
		if(obj.transform.name == "XR Interaction Setup")
		{
			opening = true;
			closing = false;
		}
	}
    
    private void OnTriggerExit(Collider obj)
    {
	    if(obj.transform.name == "XR Interaction Setup")
	    {
		    opening = false;
		    closing = true;
	    }
    }
    

    void OpenDoor()
    {
	    float movement = speed * Time.deltaTime;
	    currentValue += movement;

	    if (currentValue <= maxOpenValue)
	    {
		    door.position = new Vector3(door.position.x + movement, door.position.y, door.position.z);
	    }
	    else
	    {
		    opening = false;
	    }
    }
    
    void CloseDoor()
    {
	    float movement = speed * Time.deltaTime;
	    currentValue -= movement;

	    if (currentValue >= 0)
	    {
		    door.position = new Vector3(door.position.x - movement, door.position.y, door.position.z);
	    }
	    else
	    {
		    closing = false;
	    }
    }
}
