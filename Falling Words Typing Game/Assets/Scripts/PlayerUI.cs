using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    //These are for health
    public RectTransform healthBarFill;

    //These are for score
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        SetHealthBar(Player.healthPoints);
        DisplayScore();
    }

    public void SetHealthBar(int amt)
    {
        if (amt >= 0)
        {
            healthBarFill.localScale = new Vector3((float)amt*0.3f, 1f, 1f);
        }
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + Score.score.ToString();
    }
}
