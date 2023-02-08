using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinshooting : MonoBehaviour
{
    public float Speed = 4.5f;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Health>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }
        Destroy(gameObject);
    }
}
