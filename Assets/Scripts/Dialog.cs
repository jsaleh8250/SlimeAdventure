using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public int curTextItem;
    [TextArea()]
    public string[] dialog;

    private void Update()
    {
        GetComponentInChildren<Text>().text = dialog[curTextItem];
    }

    public void AdvanceDialog()
    {
        if (curTextItem < dialog.Length - 1)
        {
            curTextItem++;
        }
        else
        {
            GetComponentInChildren<Canvas>().enabled = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInChildren<Canvas>().enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        curTextItem = 0;
        GetComponentInChildren<Canvas>().enabled = false;
    }
}
