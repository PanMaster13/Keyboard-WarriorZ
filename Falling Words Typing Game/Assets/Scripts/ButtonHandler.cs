using UnityEngine;
using UnityEditor.SceneManagement;

using UE = UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * Main Menu - 0
    * Main - 1
    * Tutorial - 2
    * Story - 3
    */

    public void PlayGame()
    {
        Debug.Log("Play is pressed");
        UE.SceneManager.LoadScene(1); // Another way is UE.SceneManager.GetActiveScene().buildIndex + 1
    }

    public void AboutGame()
    {
        Debug.Log("About is pressed");
        UE.SceneManager.LoadScene(2); 
    }

    public void ScoreBoardGame()
    {
        Debug.Log("Score Board is pressed");
    }

    public void QuitGame()
    {
        Debug.Log("Quit is pressed");
        Application.Quit(); // Only quits the game when you export it
    }
}
