using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class GameTypeButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * Main Menu - 0
    * Tutorial - 1
    * Story - 2
    * Level1 - 3
    * Endscreen - 4
    * ScoreBoard - 5
    * EndlessRunner - 6
    * GameType - 7
    */

    public void SinglePlayerMode()
    {
        Debug.Log("Single Player Mode is selected.");
        UE.SceneManager.LoadScene(3);
    }

    public void EndlessRunnerMode()
    {
        Debug.Log("Endless Runner Mode is selected.");
        UE.SceneManager.LoadScene(6);
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
