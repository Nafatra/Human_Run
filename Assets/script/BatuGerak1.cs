using UnityEngine;
using UnityEngine.SceneManagement;

public class BatuGerak1 : MonoBehaviour
{
    public float speed = 2f;
    public float leftBound = -10f;
    public float rightStartX = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 newPosition = rb.position + Vector2.left * speed * Time.fixedDeltaTime;

        // Reset posisi kalau udah lewat batas kiri
        if (newPosition.x < leftBound)
        {
            newPosition.x = rightStartX;
        }

        // Pindahkan batu dengan cara yang aman ke posisi baru
        rb.MovePosition(newPosition);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver"); // ganti nama sesuai scene lo
        }
    }
}
