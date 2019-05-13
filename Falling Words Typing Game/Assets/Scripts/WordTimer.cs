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

    private void Start()
    {
        startTime = Time.time;
    }
    private void Update()
	{
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

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

}
