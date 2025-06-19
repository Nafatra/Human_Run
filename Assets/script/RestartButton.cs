using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public string sceneName = "SampleScene"; // Ganti sesuai nama scene gameplay lo

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
