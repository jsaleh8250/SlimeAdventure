using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthBarBehavier healthbar;
    public float numhit;
    public float hp = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        numhit = hp;
        healthbar.SetHealth(numhit, hp);
    }

    public void TakeHit(float damage)
    {
        numhit -= damage;
        healthbar.SetHealth(numhit, hp);

        if (numhit <= 0)
        {
            Destroy(gameObject);
        }

    }
}

