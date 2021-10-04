using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    public float speed = 150;

    void FixedUpdate(){
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;

        /*
         * leave the game
         */
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
    }
}
