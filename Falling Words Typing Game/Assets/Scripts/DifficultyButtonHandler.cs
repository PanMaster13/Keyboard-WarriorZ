using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class DifficultyButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * Main Menu - 0
    * Tutorial - 1
    * Story - 2
    * DifficultySelector - 3
    * EasyMode - 4
    */

    public void EasyMode()
    {
        Debug.Log("Easy Mode was Selected");
        UE.SceneManager.LoadScene(4);
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
