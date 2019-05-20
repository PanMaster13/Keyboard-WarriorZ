using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class PauseButtonHandler : MonoBehaviour
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

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ToMainMenu()
    {
        Debug.Log("Main Menu is pressed");
        Time.timeScale = 1f;
        UE.SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit is pressed");
        Application.Quit();
    }
}

