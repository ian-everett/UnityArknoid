using UnityEngine;
using UnityEngine.Events;

/*
 * Setup event so it can return an int
 */
[System.Serializable] public class IntegerEvent : UnityEvent<int> { }

public class GameManager : MonoBehaviour
{
    private int lives;
    [SerializeField] IntegerEvent updateLives;

    public void LoseLife()
    {
        if (--lives > 0)
        {
            /*
             * Invoke callback to update lives
             */
            updateLives.Invoke(lives);
        }
        else
        {
            Debug.Log("Game over");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        updateLives.Invoke(lives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
