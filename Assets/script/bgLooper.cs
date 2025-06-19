using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed = 2f;              // Kecepatan gerak
    public float backgroundWidth = 20f;   // Ukuran lebar gambar background

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); //gerakan halus, konsisten di semua FPS. (seharusnya)

        // Kalau sudah lewat batas kiri, reset posisi ke kanan
        if (transform.position.x <= -backgroundWidth)
        {
            //Karena biasanya background-nya ada 2 yang saling sambung (looping).
            transform.position += new Vector3(backgroundWidth * 2f, 0, 0);
            //Kalau A udah keluar di kiri (-20), pindahin dia ke posisi 20 lagi (makanya +40, atau backgroundWidth * 2).
        }
    }
}