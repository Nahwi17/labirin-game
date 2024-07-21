using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameOptionsManager : MonoBehaviour
{
    public GameObject inGameOptionsPanel;
    public Slider volumeSlider;
    public Button restartButton; // Tombol Mulai Ulang
    public Button backButton; // Tombol Kembali
    private bool isOptionsVisible = false;

    void Start()
    {
        // Set slider ke nilai yang tersimpan sebelumnya
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
        volumeSlider.onValueChanged.AddListener(SetVolume);
        inGameOptionsPanel.SetActive(false); // Awalnya panel tidak aktif

        // Tambahkan listener ke tombol
        restartButton.onClick.AddListener(RestartGame);
        backButton.onClick.AddListener(BackToMainMenu);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isOptionsVisible = !isOptionsVisible;
            UpdateOptionsVisibility();
        }
    }

    void UpdateOptionsVisibility()
    {
        if (isOptionsVisible)
        {
            inGameOptionsPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0; // Pause game
        }
        else
        {
            inGameOptionsPanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1; // Resume game
        }
    }

    public void SetVolume(float volume)
    {
        // Atur volume di sini, misalnya AudioListener.volume
        AudioListener.volume = volume;
        // Simpan nilai volume
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void CloseOptions()
    {
        isOptionsVisible = false;
        UpdateOptionsVisibility();
    }

    public void QuitToMainMenu()
    {
        // Resume game sebelum kembali ke main menu
        Time.timeScale = 1;
        // Ganti "MainMenu" dengan nama scene main menu Anda
        SceneManager.LoadScene("Main Menu");
    }

    // Method untuk memulai ulang game
    public void RestartGame()
    {
        // Resume game sebelum memulai ulang
        Time.timeScale = 1;
        // Ganti "Level1" dengan nama scene level pertama Anda
        SceneManager.LoadScene("Level1");
    }

    // Method untuk kembali ke main menu
    public void BackToMainMenu()
    {
        // Resume game sebelum kembali ke main menu
        Time.timeScale = 1;
        // Ganti "MainMenu" dengan nama scene main menu Anda
        SceneManager.LoadScene("Main Menu");
    }
}
