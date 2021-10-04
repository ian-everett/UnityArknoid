using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 5;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        /*
         * Block is destroyed
         * Add to player score
         * Note: gameObject is the actual object, we don't
         * want to destryoy 'this'
         */
        GameManager.AddToTotalScore(score);
        Destroy(gameObject);
    }
}
