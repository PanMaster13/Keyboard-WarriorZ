using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ElapsedTime : MonoBehaviour
{
    public Text text;
    public static string endTime;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Elapsed time: " + endTime;
    }
}
