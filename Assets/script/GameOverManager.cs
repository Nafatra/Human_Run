using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Button restartButton;   // Tombol restart

    void Start()
    {
        // Pastikan tombol restartButton sudah terhubung
        // Kalau ada, tambahin listener: saat tombol diklik, fungsi RestartGame() dijalankan.
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(RestartGame);
        }
        else
        {
            Debug.LogError("Restart Button is not assigned!");
        }
    }

    // Fungsi untuk restart game ke SampleScene
    void RestartGame()
    {
        // Muat scene SampleScene
        SceneManager.LoadScene("SampleScene");
    }
}
