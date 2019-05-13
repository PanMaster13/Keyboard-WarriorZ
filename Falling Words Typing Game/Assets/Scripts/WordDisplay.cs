using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public string initialText;
    public bool hasMinus;
    public bool agility = false;
    public float pingPong;
    public GameObject effect;

    public void SetWord(string word)
    {
        text.text = word;
        initialText = text.text;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.green;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
        Instantiate(effect, gameObject.transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if (agility == true)
        {
            if (transform.position.x <= 1)
            {
                pingPong = Mathf.PingPong(Time.time, 1);
            }
            else if (transform.position.x >= 1)
            {
                pingPong = -Mathf.PingPong(Time.time, 1);
            }
            transform.Translate(pingPong, -WordManager.fallSpeed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, -WordManager.fallSpeed * Time.deltaTime, 0f);
        }
    }

    public void SetColorRed()
    {
        text.color = Color.red;
    }
}