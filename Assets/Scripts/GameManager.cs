using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int TotalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
    }

    public static void AddToTotalScore(int score) {
        TotalScore += score;
        Debug.Log("Score = " + TotalScore);
    }
}
