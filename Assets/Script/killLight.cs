using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class killLight : MonoBehaviour
{
    [SerializeField]
    private LayerMask collisionLayer;

    private float timeToKill = 0f;
    private bool start = false;

    private GameObject enemy;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, collisionLayer))
        {
            if (hit.collider.gameObject.CompareTag("enemy"))
            {
                start = true;
                enemy = hit.collider.gameObject;
            }
        }else
        {
            start = false;
            timeToKill = 0f;
            enemy = null;
        }

        if (start)
        {
            timeToKill += Time.deltaTime;

            if (timeToKill >= 2f)
            {
                enemy.SetActive(false);
                timeToKill = 0f;
                start = false;
            }
        }
        
    }
}
