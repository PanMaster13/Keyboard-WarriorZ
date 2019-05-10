using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
public class PreviousGameScore : MonoBehaviour
{
    public Text text;
    public string gameScore;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        string filepath = Application.dataPath + "/score.txt";
        StreamReader sr = new StreamReader(filepath);
        string data = sr.ReadLine();
        string data2 = sr.ReadLine();
        gameScore = data2;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Previous Game Score: " + gameScore;
    }
}
