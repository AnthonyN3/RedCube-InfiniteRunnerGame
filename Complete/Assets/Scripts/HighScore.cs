using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    public float highScore = 0.0f;
    public Text highScoreText;

    public void Awake()
    {
        highScore = PlayerPrefs.GetFloat("highscore", 0.0f);
        highScoreText.text = string.Format("HI: {0}", Mathf.Round(highScore));
    }

    public void saveScore(float newScore)
    {
        PlayerPrefs.SetFloat("highscore", newScore);
        highScore = newScore;
        highScoreText.text = string.Format("HI: {0}", Mathf.Round(highScore));
    }
	
}
