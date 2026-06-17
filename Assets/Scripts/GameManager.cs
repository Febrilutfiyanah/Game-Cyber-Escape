using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI chipText;
    public GameObject levelCompletePanel;

    private int chipCount = 0;
    private int totalChip = 3;


    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        UpdateUI();

        // Pastikan panel kemenangan mati saat mulai
        levelCompletePanel.SetActive(false);
    }


    public void AddChip()
    {
        chipCount++;

        UpdateUI();


        if (chipCount >= totalChip)
        {
            levelCompletePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }


    void UpdateUI()
    {
        chipText.text = "DataChip : " + chipCount + "/" + totalChip;
    }
}