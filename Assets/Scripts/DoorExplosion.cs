using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExplosion : MonoBehaviour
{
    [Header("Unity Setup")]
    public ParticleSystem explosionParticles;

    private void onCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Bomb")) {
            this.Destroy();
        }
    }

    private void Destroy() {
        Instantiate(this.explosionParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
