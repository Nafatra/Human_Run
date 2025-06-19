using UnityEngine;

public class Batu : MonoBehaviour
{
    public float speed = 5f;
    public float resetX = 10f;   // Posisi X saat reset (kanan)
    public float minX = -10f;    // Batas kiri sebelum reset

    void Update()
    {
        // Gerakin ke kiri
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Kalau udah kelewat kiri, balikin ke kanan
        if (transform.position.x < minX)
        {
            Vector3 pos = transform.position;
            pos.x = resetX;
            transform.position = pos;
        }
    }
}

