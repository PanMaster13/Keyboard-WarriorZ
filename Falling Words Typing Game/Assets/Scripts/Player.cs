using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int healthPoints;
    public int invinPoints;
    public bool invinLock;
    public bool healthLock;
    public PlayerUI playerUI;

    public Player()
    {
        healthPoints = 5;
        invinPoints = 0;
    }

    public void useInvinBuff()
    {
        StartCoroutine(Delay());
        playerUI.disableText();
    }

    IEnumerator Delay()
    {
        invinLock = true;
        healthLock = true;
        while (invinPoints > 0)
        {
            invinPoints--;
            yield return new WaitForSecondsRealtime(0.5f);
            Debug.Log(invinPoints);
        }
        invinLock = false;
        healthLock = false;
    }

}
