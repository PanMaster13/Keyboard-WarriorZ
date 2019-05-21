using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System.IO;
using System.Text; 
public class UnitTest 
{
    [Test]
    public void InitScore_Test()
    {
        int expected = Score.score;
        int actual = 0;
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void RetrieveHighScore_Test()
    {
        string filepath = Application.dataPath + "/score.txt";
        StreamReader sr = new StreamReader(filepath);
        string data = sr.ReadLine();
        string expected = data;
        string actual = "71";
        Assert.AreEqual(expected, actual);
    }
}
