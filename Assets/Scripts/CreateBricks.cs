using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBricks : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    private int n_cols = 13;
    private float start_x = -96;
    private float start_y = 60;
    

    void Start()
    {
        AddBlocks();
    }

    void AddBlocks()
    {
        float y_pos = start_y;
        
        /*
         * Load each block prefab from directory
         */
        foreach (GameObject block in Resources.LoadAll<GameObject>("Prefabs/Blocks"))
        {
            Vector2 size = block.GetComponent<SpriteRenderer>().bounds.size;
            float x_pos = start_x;

            for (int col = 0; col < n_cols; col++){        
                GameObject go = Instantiate(block, new Vector2(x_pos, y_pos), Quaternion.identity);
                go.GetComponent<Block>().scoreEvent.AddListener(gameManager.AddToScore);

                x_pos += size.x;
            }
            y_pos -= size.y;
        }
    }
}
