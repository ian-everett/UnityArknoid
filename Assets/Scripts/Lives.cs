using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    [SerializeField] Text livesInfo;
    private int lives;

    private void Start()
    {
        lives = 3;
    }

    public void LoseLife()
    {
        if (--lives == 0)
        {
            /*
             * Game over
             */
        }
        else
        {
            livesInfo.text = "Lives : " + lives;
        }
    }
}
