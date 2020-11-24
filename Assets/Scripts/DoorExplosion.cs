using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExplosion : MonoBehaviour
{
    
    public GameObject explosionPrefab;

    /*void onCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Bomb" || other.gameObject.name == "SFL_Door") {
            ContactPoint contact = other.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;
            Instantiate(explosionPrefab, position, rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bomb" || other.gameObject.name == "Door") {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
