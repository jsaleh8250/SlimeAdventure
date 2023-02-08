using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformamount = 400;
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for(int i = 0; i < platformamount; i++)
        {
            spawnPosition.y += Random.Range(1f, 4f);
            spawnPosition.x = Random.Range(-8f, 8f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
