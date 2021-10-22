using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    private const int MaxLives = 3;
    private List<GameObject> lives = new List<GameObject>();


    void Start()
    {
        CreateLives();
    }


    public void RemoveLife()
    {
        int num_lives = lives.Count;

        if (num_lives > 0)
        {
            /*
             * Get last game object and remove it
             */
            GameObject go = lives[num_lives - 1];
            Destroy(go);
            lives.RemoveAt(num_lives - 1);
        }
    }


    private void CreateLives()
    {
        Canvas canvas = GetComponent<Canvas>();

        /*
         * Display lives
         */
        for (int i = 0; i < MaxLives; i++)
        {
            GameObject go = Instantiate(prefab, new Vector2(-115 + (i * 28), -290), Quaternion.identity);
            go.transform.SetParent(canvas.transform, false);

            lives.Add(go);
        }
    }
}
