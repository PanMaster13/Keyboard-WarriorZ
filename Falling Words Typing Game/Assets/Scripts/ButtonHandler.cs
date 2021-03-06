﻿using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * MainMenu - 0
    * About - 1
    * Story - 2
    * Game - 3
    * Game 1 - 4
    * Game 2 - 5
    * EndScreen - 6
    * ScoreBoard - 7
    * EndlessRunner - 8
    * GameType - 9
    * 2PlayerMode - 10
    * EndScreen 1 - 11
    * EndScreen 2 - 12
    * Instructions - 13
    * EasterEgg - 14
    */

    // This section is for Main Menu.
    public void PlayGame()
    {
        Debug.Log("Play is pressed");
        UE.SceneManager.LoadScene(9);
    }

    public void AboutGame() // Go to Tutorial Menu
    {
        Debug.Log("About is pressed");
        UE.SceneManager.LoadScene(1); 
    }

    public void ScoreBoardGame()
    {
        Debug.Log("Score Board is pressed");
        UE.SceneManager.LoadScene(7);
    }

    public void QuitGame()
    {
        Debug.Log("Quit is pressed");
        Application.Quit(); // Only quits the game when you export it
    }

    // ************************************************************************

    // This section is for Game Type Menu
    public void SinglePlayerMode()
    {
        Debug.Log("Single Player Mode is selected.");
        UE.SceneManager.LoadScene(3);
    }

    public void EndlessRunnerMode()
    {
        Debug.Log("Endless Runner Mode is selected.");
        UE.SceneManager.LoadScene(8);
    }

    public void TwoPlayerMode()
    {
        Debug.Log("Two Player Mode is selected.");
        UE.SceneManager.LoadScene(10);
    }

    // ************************************************************************

    // This section is for Difficulty Selection Menu
    public void EasyMode()
    {
        Debug.Log("Easy Mode was Selected");
    }

    public void MediumMode()
    {
        Debug.Log("Medium Mode was Selected");
    }

    public void HardMode()
    {
        Debug.Log("Hard Mode was Selected");
    }

    // ************************************************************************

    // Rematch Function.
    public void WordRematch()
    {
        Debug.Log("Rematch is pressed");
        Score.score = 0;
        ElapsedTime.endTime = "";
        UE.SceneManager.LoadScene("Game");
    }

    public void ERRematch()
    {
        Debug.Log("Rematch is pressed");
        ScoreManager.endScore = 0;
        UE.SceneManager.LoadScene("EndlessRunner");
    }

    public void TwoPRematch()
    {
        Debug.Log("Rematch is pressed");
        TwoPlayerScore.endScore = 0;
        Score.score = 0;

        UE.SceneManager.LoadScene("2PlayerMode");
    }


    // ************************************************************************

    // Proceed to Main Menu Function.
    public void ToMainMenu()
    {
        Debug.Log("Main Menu was Selected");
        UE.SceneManager.LoadScene(0);
        if(UE.SceneManager.GetActiveScene().name == "EndScreen" || UE.SceneManager.GetActiveScene().name == "Game" || UE.SceneManager.GetActiveScene().name == "Game 1" || UE.SceneManager.GetActiveScene().name == "Game 2")
        {
            Score.score = 0;
            ElapsedTime.endTime = "";
            Time.timeScale = 1f;
        }
        if(UE.SceneManager.GetActiveScene().name == "EndScreen 1" || UE.SceneManager.GetActiveScene().name == "EndlessRunner")
        {
            ScoreManager.endScore = 0;
            Time.timeScale = 1f;
        }
        if(UE.SceneManager.GetActiveScene().name == "EndScreen 2" || UE.SceneManager.GetActiveScene().name == "2PlayerMode")
        {
            TwoPlayerScore.endScore = 0;
            Score.score = 0;
            Time.timeScale = 1f;
        }
    }

    // ************************************************************************

    // Proceed to Story Menu
    public void Story()
    {
        Debug.Log("Story is pressed");
        UE.SceneManager.LoadScene(2);
    }

    //Proceed to Instructions page
    public void Instructions()
    {
        Debug.Log("Instructions is pressed");
        UE.SceneManager.LoadScene(13);
    }

    //Proceed to EasterEgg page
    public void EasterEgg()
    {
        UE.SceneManager.LoadScene(14);
    }
}
