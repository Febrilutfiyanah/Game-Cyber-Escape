using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider musicSlider;
    public GameObject settingsPanel;

    void Start()
    {
        musicSlider.value = AudioListener.volume;
    }

    public void SetVolume()
    {
        AudioListener.volume = musicSlider.value;
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
}