using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFinishManager : MonoBehaviour
{
    public GameObject finishPanel; // Panel UI untuk Selesai
    public Button restartButton; // Tombol Mulai Ulang
    public Button homeButton; // Tombol Home

    private void Start()
    {
        // Sembunyikan panel Selesai saat mulai
        finishPanel.SetActive(false);
        // Tambahkan listener ke tombol Mulai Ulang
        restartButton.onClick.AddListener(RestartGame);
        // Tambahkan listener ke tombol Home
        homeButton.onClick.AddListener(GoToMainMenu);
    }

    // Method untuk menampilkan panel Selesai
    public void ShowFinishUI()
    {
        finishPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Membebaskan kursor
        Cursor.visible = true; // Menampilkan kursor
    }

    // Method untuk memulai ulang game
    private void RestartGame()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mengunci kembali kursor
        Cursor.visible = false; // Menyembunyikan kursor
        SceneManager.LoadScene("Level1"); // Ganti "Level1" dengan nama scene level pertama
    }

    // Method untuk kembali ke main menu
    private void GoToMainMenu()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mengunci kembali kursor
        Cursor.visible = false; // Menyembunyikan kursor
        SceneManager.LoadScene("MainMenu"); // Ganti "MainMenu" dengan nama scene main menu
    }
}
