using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{

    private static int scores;
    public coinshooting coinPrefab;
    public Transform shootoffset;
    public int count;
    void Update()
    { 
        scores = Score.score;

        if(scores > 0)
        {
            this.enabled = true;
        }
        else
        {
            this.enabled = false;
        }
       


        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(coinPrefab, shootoffset.position, transform.rotation);
            count++;
           
        }

        if(count >= scores)
        {
            this.enabled = false;
        }
       
    }

}
