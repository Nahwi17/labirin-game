using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFinishManager : MonoBehaviour
{
    public GameObject finishPanel; // Panel UI untuk Selesai
    public Button restartButton; // Tombol Mulai Ulang
    public Button exitButton; // Tombol Keluar
    public string nextLevelName; // Nama level berikutnya
    public string ToMainMenu; // Nama level berikutnya

    private void Start()
    {
        // Sembunyikan panel Selesai saat mulai
        finishPanel.SetActive(false);
        // Tambahkan listener ke tombol Mulai Ulang
        restartButton.onClick.AddListener(RestartGame);
        // Tambahkan listener ke tombol Keluar
        exitButton.onClick.AddListener(ExitToMainMenu);
    }

    // Method ini dipanggil ketika sesuatu masuk ke dalam trigger
    private void OnTriggerEnter(Collider other)
    {
        // Periksa apakah yang masuk trigger adalah player
        if (other.CompareTag("Player"))
        {
            ShowFinishUI();
        }
    }

    // Method untuk menampilkan panel Selesai
    private void ShowFinishUI()
    {
        finishPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Membebaskan kursor
        Cursor.visible = true; // Menampilkan kursor
        Time.timeScale = 0; // Pause game
    }

    // Method untuk memulai ulang game
    private void RestartGame()
    {
        Time.timeScale = 1; // Resume game sebelum memulai ulang
        Cursor.lockState = CursorLockMode.Locked; // Mengunci kembali kursor
        Cursor.visible = false; // Menyembunyikan kursor
        SceneManager.LoadScene(nextLevelName); // Ganti "Level1" dengan nama scene level pertama
    }

    // Method untuk kembali ke main menu
    private void ExitToMainMenu()
    {
        Time.timeScale = 1; // Resume game sebelum kembali ke main menu
        Cursor.lockState = CursorLockMode.Locked; // Mengunci kembali kursor
        Cursor.visible = false; // Menyembunyikan kursor
        SceneManager.LoadScene(ToMainMenu); // Ganti "MainMenu" dengan nama scene main menu
    }
}
