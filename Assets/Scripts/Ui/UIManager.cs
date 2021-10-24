using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text score;

    void Start()
    {
        score = GetComponentInChildren<Text>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void UpdateScore(int total)
    {
        score.text = "Score: " + total;
    }
}
