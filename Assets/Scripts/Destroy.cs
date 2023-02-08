using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string tag;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Platform")
        {
            Destroy(collision.gameObject);
            Debug.Log("destroy");
        }
    }
}
