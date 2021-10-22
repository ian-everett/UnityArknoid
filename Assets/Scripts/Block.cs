using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    /*
     * Keep track of blocks
     */
    private static int n_blocks = 0;

    void Start()
    {
        n_blocks++;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Destroy(gameObject);
    }
}
