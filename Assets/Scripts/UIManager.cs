using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject aboutPanel;

    public void ShowAbout()
    {
        aboutPanel.SetActive(true);
    }

    public void CloseAbout()
    {
        aboutPanel.SetActive(false);
    }
}