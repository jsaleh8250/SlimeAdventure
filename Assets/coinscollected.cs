using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscollected : MonoBehaviour
{
    public static int score;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = Score.score.ToString();
    }
}
