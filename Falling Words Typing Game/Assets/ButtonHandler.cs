using UnityEngine;
using UnityEditor.SceneManagement;

using UE = UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play is pressed");
        UE.SceneManager.LoadScene(UE.SceneManager.GetActiveScene().buildIndex + 1); //Another way is EditorSceneManager.LoadScene()
    }

    public void AboutGame()
    {
        Debug.Log("About is pressed");
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
