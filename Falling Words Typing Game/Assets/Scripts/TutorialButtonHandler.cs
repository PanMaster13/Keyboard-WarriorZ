using UnityEngine;
using UnityEditor.SceneManagement;

using UE = UnityEngine.SceneManagement;

public class TutorialButtonHandler : MonoBehaviour
{
    /*
     * Build Index Reference (For LoadScene Function)
     * Main Menu - 0
     * Main - 1
     * Tutorial - 2
     * Story - 3
     */

    public void MainMenu()
    {
        Debug.Log("Main Menu is pressed");
        UE.SceneManager.LoadScene(0); //Another way is EditorSceneManager.LoadScene()
    }

    public void Story()
    {
        Debug.Log("Story is pressed");
        UE.SceneManager.LoadScene(3); 
    }
}
