using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class GameTypeButtonHandler : MonoBehaviour
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

    public void SinglePlayerMode()
    {
        Debug.Log("Single Player Mode is selected.");
    }

    public void EndlessRunnerMode()
    {
        Debug.Log("Endless Runner Mode is selected.");
    }

    public void TwoPlayerMode()
    {
        Debug.Log("Two Player Mode is selected.");
    }

    public void ToMainMenu()
    {
        Debug.Log("Main Menu was Selected");
        UE.SceneManager.LoadScene(0);
    }
}
