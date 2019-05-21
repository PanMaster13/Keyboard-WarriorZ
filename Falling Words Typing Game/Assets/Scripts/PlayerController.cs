using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UE = UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * MainMenu - 0
    * Tutorial - 1
    * Story - 2
    * Game - 3
    * Game 1 - 4
    * Game 2 - 5
    * EndScreen - 6
    * ScoreBoard - 7
    * EndlessRunner - 8
    * GameType - 9
    * Test - 10
    * 2PlayerMode - 11
    */

    private Vector2 targetPos;
    public float Xmove;

    public float speed;
    private float maxX;
    private float minX;

    public int health = 5;
    public Text healthDisplay;

    void Start()
    {
        targetPos = transform.position;
        maxX = transform.position.x + 299;
        minX = transform.position.x - 299;
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = "HP: " + health.ToString();

        if (health <= 0)
        {
            UE.SceneManager.LoadScene("EndScreen 2");
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
        {
            
            targetPos = new Vector2(transform.position.x + Xmove, transform.position.y);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
        {
            
            targetPos = new Vector2(transform.position.x - Xmove, transform.position.y);
        }

        
    }
}
