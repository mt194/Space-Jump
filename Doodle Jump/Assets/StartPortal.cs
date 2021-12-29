using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPortal : MonoBehaviour {

    public GameObject EndPortal;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null) {
                rb.position = EndPortal.transform.position;                     //on collision, set collider's new position to end portal position
            }
        }
    }
}
