using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Intro");
    }
    public void OnRulesButton()
    {
        SceneManager.LoadScene("Rules");
    }
}
