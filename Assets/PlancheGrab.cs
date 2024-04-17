using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlancheGrab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hammer"))
        { 
            transform.parent = other.gameObject.transform;
            gameObject.AddComponent<XRGrabInteractable>();
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
        gameObject.GetComponent<Rigidbody>().useGravity = true;

    }
}
