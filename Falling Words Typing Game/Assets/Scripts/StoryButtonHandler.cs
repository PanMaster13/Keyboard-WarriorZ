using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class StoryButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * Main Menu - 0
    * Tutorial - 1
    * Story - 2
    * Game - 3
    * Endscreen - 4
    * ScoreBoard - 5
    * EndlessRunner - 6
    * GameType - 7
    */

    public void MainMenu()
    {
        Debug.Log("Main Menu is pressed");
        UE.SceneManager.LoadScene(0); //Another way is EditorSceneManager.LoadScene()
    }

    public void Tutorial()
    {
        Debug.Log("Tutorial is pressed");
        UE.SceneManager.LoadScene(1);
    }
}
