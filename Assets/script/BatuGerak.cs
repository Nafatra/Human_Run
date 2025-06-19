using UnityEngine;
using UnityEngine.SceneManagement;

public class BatuGerak : MonoBehaviour
{
    // kalau batu udah kelewat titik ini (misalnya keluar layar kiri), dia reset ke kanan.
    public float speed = 2f;
    public float leftBound = -10f;
    public float rightStartX = 10f;

    private Rigidbody2D rb;
    
    //Pas pertama kali jalan (start), ambil Rigidbody2D dari GameObject.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Gerakin posisi batu ke kiri tiap frame (Vector2.left artinya ke kiri, dikali speed dan waktu).
        Vector2 newPosition = rb.position + Vector2.left * speed * Time.fixedDeltaTime;

        // Reset posisi kalau udah lewat batas kiri (looping)
        if (newPosition.x < leftBound)
        {
            newPosition.x = rightStartX;
        }

        // Pindahkan batu dengan cara yang aman ke posisi baru
        rb.MovePosition(newPosition);
    }

    //Kalau batu nabrak objek lain yang punya tag "Player", langsung ganti scene ke "GameOver".
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver"); // ganti sesuai nama scene 
        }
    }
}
