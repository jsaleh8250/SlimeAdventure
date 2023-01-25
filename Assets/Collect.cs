using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collect : MonoBehaviour
{
  
    public string tag;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Coins")
        {
            Destroy(collision.gameObject);
            

            Score.score++;
        }
    }
}
