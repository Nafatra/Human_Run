using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; //bisa diakses dari mana aja lewat ScoreManager.Instance.

    public Text scoreText;

    private float score = 0f; //nilai score nya biar smooth naiknya

    //Set Instance cuma sekali pas game mulai.Penting supaya gak dobel kalau scene di restart. 
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        score = 0f; //Reset skor pas game mulai.
    }

    void Update()
    {
        score += Time.deltaTime * 20f; // tambah 20 poin per detik
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString(); //Tampilkan skor di UI ScoreText
    }

    // baut nyimpen sama manggil score (yang ini gak kepake di game nya klo gak salah) 
    public void SaveScore()
    {
        PlayerPrefs.SetInt("LastScore", Mathf.FloorToInt(score));
        PlayerPrefs.Save();
    }

    public int GetScore()
    {
        return Mathf.FloorToInt(score);
    }
}
