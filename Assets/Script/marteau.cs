using UnityEngine;

public class MarteauCollision : MonoBehaviour
{
    [SerializeField] private GameObject planche; // Référence au GameObject de la planche
    private Rigidbody _marteauRigidbody; // Référence au Rigidbody du marteau

    private void Start()
    {
        _marteauRigidbody = GetComponent<Rigidbody>(); // Récupère le Rigidbody du marteau au démarrage
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == planche)
        {
            Debug.Log("Le marteau touche la planche !");
            
            // Attache le marteau à la planche en désactivant la gravité
            _marteauRigidbody.isKinematic = true;
            _marteauRigidbody.transform.SetParent(planche.transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == planche)
        {
            Debug.Log("Le marteau quitte la planche !");
            
            // Détache le marteau de la planche en réactivant la gravité
            _marteauRigidbody.isKinematic = false;
            _marteauRigidbody.transform.SetParent(null);
        }
    }
}