using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            // Reload scene atau ganti ke game over screen
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
