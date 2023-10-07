using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer9 : MonoBehaviour
{
     void OnCollisionEnter(Collision collision) {
        Debug.Log("Colisión detectada");
        Debug.Log("Soy " + gameObject.name + " y acabo de detectar una colisión con " + collision.gameObject.name);
    }
    
    void OnTriggerEnter(Collider collider) {
        Debug.Log("Trigger detectado");
        Debug.Log("Soy " + gameObject.name + " y acabo de detectar una colisión con " + collider.gameObject.name);
    }
}
