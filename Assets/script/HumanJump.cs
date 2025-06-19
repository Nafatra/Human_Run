using UnityEngine;

//Class utama buat ngatur loncatan karakter.
public class HumanJump : MonoBehaviour
{
    //Besarnya gaya loncat. Bisa atur dari Inspector Unity.
    public float jumpForce = 12f;
    private Rigidbody2D rb; // buat akses komponen fisika 2D.
    private bool isGrounded = false; //buat cek apakah karakter lagi nyentuh tanah atau nggak (biar gak bisa spam loncat di udara).

    //Pas mulai game, script ini ambil komponen Rigidbody2D dari GameObject tempat dia nempel.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Cek tiap frame apakah tombol panah atas ditekan DAN karakter lagi di tanah.
    void Update()
    {
        // Loncat saat tekan panah atas
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // diubah sumbu Y-nya aja buat kasih efek loncat vertikal, ke atas.
            isGrounded = false; //Setelah loncat, set isGrounded = false biar gak bisa loncat lagi sebelum mendarat.
        }
    }
    //Kalau karakter nabrak sesuatu (biasanya tanah), anggap dia udah mendarat → bisa loncat lagi.
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Deteksi nyentuh tanah (apa aja yang punya collider)
        isGrounded = true;
    }
}
