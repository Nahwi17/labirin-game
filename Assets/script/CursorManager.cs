using UnityEngine;

public class CursorManager : MonoBehaviour
{
    private bool cursorLocked = true;

    void Start()
    {
        // Sembunyikan kursor dan kunci di tengah layar ketika game dimulai
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

/*
    void Update()
    {
        // Ketika tombol ESC ditekan, kursor muncul dan tidak terkunci
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cursorLocked = !cursorLocked;
            UpdateCursorState();
        }

        // Ketika ada input dari mouse atau keyboard, sembunyikan kursor dan kunci di tengah layar
        if (cursorLocked && (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.anyKeyDown))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

 
   
    void UpdateCursorState()
    {
        if (cursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    */
}
