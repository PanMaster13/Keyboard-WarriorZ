using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * MainMenu - 0
    * Tutorial - 1
    * Story - 2
    * Game - 3
    * Game 1 - 4
    * Game 2 - 5
    * EndScreen - 6
    * ScoreBoard - 7
    * EndlessRunner - 8
    * GameType - 9
    * Test - 10
    * 2PlayerMode - 11
    */

    public void PlayGame()
    {
        Debug.Log("Play is pressed");
        UE.SceneManager.LoadScene(9);
    }

    public void AboutGame()
    {
        Debug.Log("About is pressed");
        UE.SceneManager.LoadScene(1); 
    }

    public void ScoreBoardGame()
    {
        Debug.Log("Score Board is pressed");
        UE.SceneManager.LoadScene(7);
    }

    public void Rematch()
    {
        Debug.Log("Rematch is pressed");
        Score.score = 0;
        ElapsedTime.endTime = "";
        UE.SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Debug.Log("Quit is pressed");
        Application.Quit(); // Only quits the game when you export it
    }
}
