using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject healthbar;
    public float numhit = 0;
    float hp = 1;
    float intXScale;

    // Start is called before the first frame update
    void Start()
    {
        intXScale = healthbar.transform.localScale.x;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        numhit++;

        float percentage = (hp - numhit) / hp;
        healthbar.transform.localScale = new Vector2(percentage * intXScale, healthbar.transform.localScale.y);

        if (numhit == hp)
        {
            Destroy(gameObject);
        }
    }
}
