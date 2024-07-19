using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour
{
    public string nextLevelName; // Nama level berikutnya
    public GameObject uiPanel; // Panel UI yang menampilkan pesan
    public Button okButton; // Tombol OK

    private void Start()
    {
        // Sembunyikan UI Panel saat mulai
        uiPanel.SetActive(false);
        // Tambahkan listener ke tombol OK
        okButton.onClick.AddListener(ChangeLevel);
    }

    // Method ini dipanggil ketika sesuatu masuk ke dalam trigger
    private void OnTriggerEnter(Collider other)
    {
        // Periksa apakah yang masuk trigger adalah player
        if (other.CompareTag("Player"))
        {
            ShowUI();
        }
    }

    // Method untuk menampilkan UI
    private void ShowUI()
    {
        uiPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Membebaskan kursor
        Cursor.visible = true; // Menampilkan kursor
    }

    // Method untuk mengganti level
    private void ChangeLevel()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mengunci kembali kursor
        Cursor.visible = false; // Menyembunyikan kursor
        SceneManager.LoadScene(nextLevelName);
    }
}
