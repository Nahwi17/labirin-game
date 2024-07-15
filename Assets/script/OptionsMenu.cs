using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject MainMenuPanel;
    public Slider volumeSlider;

    private void Start()
    {
        // Set slider ke nilai yang tersimpan sebelumnya
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }

    public void OpenMainMenu()
    {
        MainMenuPanel.SetActive(true);
    }

    public void CloseMainMenu()
    {
        MainMenuPanel.SetActive(false);
    }

    public void SetVolume(float volume)
    {
        // Atur volume di sini, misalnya AudioListener.volume
        AudioListener.volume = volume;
        // Simpan nilai volume
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
