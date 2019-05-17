using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TwoPlayerScore : MonoBehaviour
{
    public int trueScore;
    public Text trueScoreDisplay;
    public GameObject runnerScore;
    
    // Start is called before the first frame update
    void Start()
    {
        trueScoreDisplay.text = "Score: " + trueScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        trueScore = runnerScore.GetComponent<ScoreManager>().score + Score.score;
        trueScoreDisplay.text = "Score: " + trueScore.ToString();

    }
}
