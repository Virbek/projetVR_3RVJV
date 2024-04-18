using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlancheGrab : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hammer"))
        { 
            transform.parent = other.gameObject.transform;
            gameObject.AddComponent<XRGrabInteractable>();
            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
        if (TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
        {
            rigidbody.useGravity = true;
        }

    }
}
