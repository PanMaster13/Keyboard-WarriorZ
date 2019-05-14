using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;

	public float wordDelay = 1.5f;
	private float nextWordTime = 0f;

    public Text timerText;
    public float startTime;
    public float endTime;
    public int wpm;

    public Text speedChgText;
    private int randSeconds;
    private float prevTime;

    private void Start()
    {
        startTime = Time.time;
        randSeconds = Random.Range(10, 20);
        prevTime = Time.time;
    }
    private void Update()
	{
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        suddenChallenge((int)t);

        timerText.text = "Time: " + minutes + ":" + seconds;
        if (Time.time >= nextWordTime && wordManager.player.healthPoints != 0)
		{
			wordManager.AddWord();
			nextWordTime = Time.time + wordDelay;
			wordDelay *= .99f;
		}
        if (wordManager.player.healthPoints == 0)
        {
            ElapsedTime.endTime += timerText.text;
            wpm = Score.score / 5;
            WPM.wpm += wpm.ToString();
            wordManager.EndGame();
        }
    }

    void suddenChallenge(int t)
    {
        if ((t - (int)prevTime) == randSeconds)
        {
            StartCoroutine(SpeedChange());
            randSeconds = Random.Range(30, 50);
            prevTime = t;
        }
    }

    IEnumerator SpeedChange()
    {
        speedChgText.gameObject.SetActive(true);
        wordManager.scoreValue = 3;
        WordManager.fallSpeed += 2f;
        yield return new WaitForSeconds(15);
        speedChgText.gameObject.SetActive(false);
        WordManager.fallSpeed -= 2f;
        wordManager.scoreValue = 1;

    }

}
