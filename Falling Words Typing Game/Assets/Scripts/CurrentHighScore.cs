using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
public class CurrentHighScore : MonoBehaviour
{
    public Text text;
    public string hiScore;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        string filepath = Application.dataPath + "/score.txt";
        StreamReader sr = new StreamReader(filepath);
        string data = sr.ReadLine();
        hiScore = data;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Current High Score: " + hiScore;
    }
}
