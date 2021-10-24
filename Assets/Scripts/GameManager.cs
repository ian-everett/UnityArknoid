using UnityEngine;
using UnityEngine.Events;

/*
 * Setup event so it can return an int
 */
[System.Serializable] public class IntegerEvent : UnityEvent<int> { }

public class GameManager : MonoBehaviour
{
    [SerializeField] IntegerEvent updateLives;
    [SerializeField] UIManager ui;
    private int lives;
    private int totalScore;

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
        totalScore = 0;
    }


    public void AddToScore(int score)
    {
        totalScore += score;
        ui.UpdateScore(totalScore);
    }
}
