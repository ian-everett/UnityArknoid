using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 5;

    /*
     * Keep track of blocks
     */
    private static int n_blocks = 0;

    void Start()
    {
        n_blocks++;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {

        /*
         * Block is destroyed
         * Add to player score
         * Note: gameObject is the actual object, we don't
         * want to destryoy 'this'
         */
        GameManager.AddToTotalScore(score);

        /*
         * When no more blocks player has won
         */
        if (--n_blocks == 0)
        {
            GameManager.PlayerHasWon();
        }
        FindObjectOfType<Score>().AddScore(100);
        Destroy(gameObject);
    }
}
