using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public static int score = 0;
    public static Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(scene.name+" "+WordManager.difficultyValue);
        if (Score.score == 30 && scene.name.Equals("Game"))
        {
            ElapsedTime.endTime = "";
            WordManager.difficultyValue = WordManager.Difficulty.Medium;
            SceneManager.LoadScene("Game 1");
        }
        if (Score.score == 80 && scene.name.Equals("Game"))
        {
            ElapsedTime.endTime = "";
            WordManager.difficultyValue = WordManager.Difficulty.Hard;
            SceneManager.LoadScene("Game 2");
        }
    }
}