using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreInfo;
    private int totalScore;

    private void Start()
    {
        totalScore = 0;
    }

    public void AddScore(int score)
    {
        totalScore += score;
        scoreInfo.text = "Score : " + totalScore;
    }
}
