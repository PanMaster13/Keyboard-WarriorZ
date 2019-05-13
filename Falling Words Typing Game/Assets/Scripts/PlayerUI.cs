using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    //These are for bars for health and invincibility
    public RectTransform healthBarFill;
    public RectTransform invinBarFill;

    //These are texts for score and invincibility bar
    public Text scoreText;
    public Text invinBarText;

    //Store an player object to access its stats
    public Player player;

    // Update is called once per frame
    void Update()
    {
        SetHealthBar(player.healthPoints);
        SetInvinBar(player.invinPoints);
        DisplayScore();
    }

    public void SetHealthBar(int amt)
    {
        if (amt >= 0)
        {
            healthBarFill.localScale = new Vector3((float)amt*0.2f, 1f, 1f);
        }
    }

    public void SetInvinBar(int amt)
    {
        if (amt >= 0)
        {
            invinBarFill.localScale = new Vector3((float)amt * 0.05f, 1f, 1f);
            if (amt >= 20)
            {
                invinBarText.gameObject.SetActive(true);
            }
        }
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + Score.score.ToString();
    }
}
