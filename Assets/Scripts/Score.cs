using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreInfo;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
    //    scoreInfo.text = "Score : " + score;
    }

    public void AddScore(int sc)
    {
        score += sc;
        scoreInfo.text = "Score : " + score;
    }
}
