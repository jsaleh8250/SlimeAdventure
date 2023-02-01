using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public TextMesh ScoreText;

    void Update()
    {
        GetComponent<TextMesh>().text = Score.score.ToString();

        
    }
}
