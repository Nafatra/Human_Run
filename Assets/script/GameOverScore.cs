using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text finalScoreText;
   

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
       
        finalScoreText.text = "Your Score: " + lastScore.ToString();
        
    }
}
