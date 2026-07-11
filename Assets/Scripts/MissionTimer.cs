using UnityEngine;
using TMPro;

public class MissionTimer : MonoBehaviour
{
    [Header("Timer Setting")]
    public float missionTime = 45f;

    public TMP_Text timerText;
    public GameObject gameOverPanel;

    // Menyimpan waktu terakhir
    public static string lastTime = "00:00";

    private bool timerRunning = true;

    void Start()
    {
        Time.timeScale = 1f;
        timerRunning = true;
        UpdateTimerUI();
    }

    void Update()
    {
        if (!timerRunning)
            return;

        missionTime -= Time.deltaTime;

        if (missionTime <= 0)
        {
            missionTime = 0;
            timerRunning = false;

            UpdateTimerUI();
            GameOver();
            return;
        }

        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        int minute = Mathf.FloorToInt(missionTime / 60);
        int second = Mathf.FloorToInt(missionTime % 60);

        lastTime = string.Format("{0:00}:{1:00}", minute, second);

        if (timerText != null)
            timerText.text = lastTime;
    }

    public string GetTimeLeft()
    {
        return lastTime;
    }

    public float GetRemainingTime()
    {
        return missionTime;
    }

    void GameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }
}