using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;  
    }

    void OnCollisionEnter2D(Collision2D col) {
        /*
         * This function is called whenever the ball collides
         * with something, we onlyZZZneed to test for the racket being hit
         */
        if (col.gameObject.name == "Racket") {
            
            float x = hitFactor(transform.position,
                            col.transform.position,
                            col.collider.bounds.size.x);

            /*
             * Calculate direction, set length to 1
             */
            Vector2 dir = new Vector2(x, 1).normalized;

            /*
             * Set Velocity with dir * speed
             */
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,float racketWidth) {
        /*
         * 1  -0.5  0  0.5   1  <- x value
         * ===================  <- racket
         */
        return (ballPos.x - racketPos.x) / racketWidth;
    }
}
