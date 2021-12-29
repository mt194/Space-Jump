using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public float jumpForce = 10f;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.y <= 0f) {                               //collider moving downwards
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();    //capture collider
            if (rb != null) {       
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;                                         //set new collider speed as jumpForce
                rb.velocity = velocity;
            }
        }
    }

}
