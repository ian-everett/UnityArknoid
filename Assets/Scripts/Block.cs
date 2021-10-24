using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] public IntegerEvent scoreEvent;
    public int score;

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
        scoreEvent.Invoke(score);
        Destroy(gameObject);
    }
}
