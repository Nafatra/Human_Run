using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public string sceneName = "MainMenu"; // Ganti sesuai nama scene gameplay lo

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
