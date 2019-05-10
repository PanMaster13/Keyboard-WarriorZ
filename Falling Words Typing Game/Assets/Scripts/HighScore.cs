using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
public class HighScore : MonoBehaviour
{
    public Text text;
    public GameObject obj;
    public static string hiScore;

    public int[] readNum; //first element is the highscore, second element is the game score
    public string[] readString; //first element is highscore string, second element is game score string

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        obj.gameObject.SetActive(false);

        //reading from file
        StreamReader sr = new StreamReader("score.txt");
        string data = sr.ReadLine();
        for (int i = 0; data != null; i++)
        {
            readString[i] = data;
            data = sr.ReadLine();
        }
        //conversion to malleable int variable
        for (int i = 0; 0 < readString.Length; i++)
        {
            readNum[i] = Convert.ToInt32(readString[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score > readNum[0])
        {
            readNum[0] = Score.score;
            readNum[1] = Score.score;
            hiScore = Score.score.ToString();
            obj.gameObject.SetActive(true);
            using (StreamWriter sw = new StreamWriter("score.txt"))
            {
                sw.WriteLine(readNum[0].ToString() +
                    "\n" + readNum[1].ToString());
            }
        }
        else
        {
            readNum[1] = Score.score;
            using (StreamWriter sw = new StreamWriter("score.txt"))
            {
                sw.WriteLine(readNum[0].ToString() +
                    "\n" + readNum[1].ToString());
            }
        }

        text.text = "High Score: " + hiScore;
    }
}
