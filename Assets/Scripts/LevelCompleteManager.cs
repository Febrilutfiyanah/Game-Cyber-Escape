using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}