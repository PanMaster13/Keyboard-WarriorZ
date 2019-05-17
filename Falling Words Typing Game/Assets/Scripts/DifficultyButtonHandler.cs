using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class DifficultyButtonHandler : MonoBehaviour
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

    public void ToMainMenu()
    {
        Debug.Log("Main Menu was Selected");
        UE.SceneManager.LoadScene(0);
    }
}
