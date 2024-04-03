using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;

    }

   public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SaveHighScore"))
        {
           if(score>PlayerPrefs.GetInt("SaveHighScore"))
            {
                PlayerPrefs.SetInt("SaveHighScore", score);
               
            }
        }
        else
        {
            PlayerPrefs.SetInt("SaveHighScore", score);
        }

        finalScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SaveHighScore").ToString();
    }


}
