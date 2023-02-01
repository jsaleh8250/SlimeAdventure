using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearPlatForm : MonoBehaviour
{
    private Rigidbody2D rb;
    public float fallDelay = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            StartCoroutine(fall());
        }
    }
    IEnumerator fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.isKinematic = false;
        GetComponent<Collider2D>().isTrigger = true;
        yield return 0;
    }
}
