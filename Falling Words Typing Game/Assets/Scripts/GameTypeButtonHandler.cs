using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class GameTypeButtonHandler : MonoBehaviour
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
        UE.SceneManager.LoadScene(11);
    }

    public void ToMainMenu()
    {
        Debug.Log("Main Menu was Selected");
        UE.SceneManager.LoadScene(0);
    }
}
