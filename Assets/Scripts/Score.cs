using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = Score.score.ToString();

        if (Score.score == 100)
        {
            Time.timeScale = 0;
        }
    }
}
