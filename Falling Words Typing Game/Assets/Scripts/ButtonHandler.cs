using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * Main Menu - 0
    * Tutorial - 1
    * Story - 2
    * DifficultySelector - 3
    * Game - 4
    * EndScreen - 5
    * ScoreBoard - 6
    */

    public void PlayGame()
    {
        Debug.Log("Play is pressed");
        UE.SceneManager.LoadScene(3);
    }

    public void AboutGame()
    {
        Debug.Log("About is pressed");
        UE.SceneManager.LoadScene(1); 
    }

    public void ScoreBoardGame()
    {
        Debug.Log("Score Board is pressed");
        UE.SceneManager.LoadScene(6);
    }

    public void Rematch()
    {
        Debug.Log("Rematch is pressed");
        Score.score = 0;
        ElapsedTime.endTime = "";
        UE.SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Quit is pressed");
        Application.Quit(); // Only quits the game when you export it
    }
}
