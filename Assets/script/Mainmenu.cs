
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Ganti "GameScene" dengan nama scene game Anda
        SceneManager.LoadScene(1);
    }


    //  public void OpenOptions()
    // {
    // Logika untuk membuka menu opsi
    //  Debug.Log("Options Menu Opened");
    //}
    public OptionsMenu optionsMenu;

    public void OpenOptions()
    {
        optionsMenu.OpenOptions();
    }

    
    public void QuitGame()
    {
       // Debug.Log("Quit Game");
        Application.Quit();
    }
}
