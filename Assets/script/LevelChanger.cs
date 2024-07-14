using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public string nextLevelName; // Nama level berikutnya

    // Method ini dipanggil ketika sesuatu masuk ke dalam trigger
    private void OnTriggerEnter(Collider other)
    {
        // Periksa apakah yang masuk trigger adalah player
        if (other.CompareTag("Player"))
        {
            ChangeLevel();
        }
    }

    // Method untuk mengganti level
    private void ChangeLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
