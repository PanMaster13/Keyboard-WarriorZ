using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffDisplay : MonoBehaviour
{
    public Text buffText;

    public void displayBuffText(string word)
    {
        if (word == "slowbuff")
        {
            buffText.text = "Word speed decreased.";
        }
        else if (word == "healthbuff")
        {
            buffText.text = "Health increased by 1.";
        }

        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        buffText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        buffText.gameObject.SetActive(false);
    }
}
