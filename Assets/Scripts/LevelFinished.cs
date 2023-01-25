using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour
{
    public string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextScene);
    }
}
