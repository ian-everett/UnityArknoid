using System.Collections.Generic;
using UnityEngine;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    private List<GameObject> lives = new List<GameObject>();


    public void UpdateLife(int n_lives)
    {
        /*
         * Remove all lives
         */
        if (lives.Count > 0)
        {
            foreach (GameObject life in lives)
                Destroy(life);
            lives.Clear();
        }

        /*
         * Build them again
         */
        CreateLives(n_lives);
    }


    private void CreateLives(int n_lives)
    {
        Canvas canvas = GetComponent<Canvas>();

        /*
         * Display lives
         */
        for (int i = 0; i < n_lives; i++)
        {
            GameObject go = Instantiate(prefab, new Vector2(-310 + (i * 35), 50), Quaternion.identity);
            go.transform.SetParent(canvas.transform, false);

            /*
             * Add ti list
             */
            lives.Add(go);
        }
    }
}
