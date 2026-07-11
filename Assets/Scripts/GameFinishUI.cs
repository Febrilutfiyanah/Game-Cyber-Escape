using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinishUI : MonoBehaviour
{
    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene"); // Level 1
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}