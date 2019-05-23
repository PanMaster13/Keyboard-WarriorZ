using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;

public class HighScoreER : MonoBehaviour
{
    public Text text;
    public static string testText;
    public string stringHiScore;
    public string stringGameScore;
    public int intHiScore;
    public int intGameScore;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        string filepath = Application.dataPath + "/scoreER.txt";
        StreamReader sr = new StreamReader(filepath);
        string data = sr.ReadLine();
        string data2 = sr.ReadLine();
        stringHiScore = data;
        stringGameScore = data2;
        intHiScore = Convert.ToInt32(stringHiScore);
        intGameScore = Convert.ToInt32(stringGameScore);

    }

    // Update is called once per frame
    void Update()
    {

        if (ScoreManager.endScore > intHiScore)
        {
            intHiScore = ScoreManager.endScore;
            intGameScore = intHiScore;
            testText = intHiScore.ToString();
            string filepath = Application.dataPath + "/scoreER.txt";
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(intHiScore.ToString());
            }
        }
        else
        {
            intGameScore = ScoreManager.endScore;
            testText = intHiScore.ToString();
            string filepath = Application.dataPath + "/scoreER.txt";
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(intHiScore.ToString());
            }
        }
        text.text = "High Score: " + testText;
    }
}
