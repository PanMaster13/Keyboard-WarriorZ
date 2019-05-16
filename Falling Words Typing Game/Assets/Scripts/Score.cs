using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score == 1)
        {
            ElapsedTime.endTime = "";
            WordManager.difficultyValue = WordManager.Difficulty.Medium;
            SceneManager.LoadScene("Game 1");
        }

    }
}