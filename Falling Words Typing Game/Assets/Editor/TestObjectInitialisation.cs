using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;

public class TestObjectInitialisation : MonoBehaviour
{
    [Test]
    public void TestPlayerControllerHealth()
    {
        PlayerController player1 = new PlayerController();
        int health = player1.health;

        Assert.AreEqual(5, health);
    }

    [Test]
    public void TestObstacleDamage()
    {
        Obstacle obstacle1 = new Obstacle();
        int damage = obstacle1.damage;

        Assert.AreEqual(1, damage);
    }

    [Test]
    public void TestPauseButton()
    {
        PauseButtonHandler pauseButton1 = new PauseButtonHandler();
        bool gameIsPaused = pauseButton1.GameIsPaused;

        Assert.IsFalse(gameIsPaused);
    }

}
