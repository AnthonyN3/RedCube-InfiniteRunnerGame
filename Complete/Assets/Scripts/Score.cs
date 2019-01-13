using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoretext;

    static float  score; 
	static float highscore;

	private HighScore highScore;

	// public Text hiscoreText;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if(player == null)
            player = GameObject.FindGameObjectWithTag("Player").transform;
        
        if (PlayerPrefs.HasKey("Highscore")){
			highscore = PlayerPrefs.GetFloat("Highscore");
		}
		else{
			highscore = 0; 
			PlayerPrefs.SetFloat("Highscore", highscore);
		}

		highScore = FindObjectOfType<HighScore>();
    }

	// Update is called once per frame
	void Update () {
        score = player.position.z;
        scoretext.text = score.ToString("0");
	
		if(score > highScore.highScore)
		{
			highScore.saveScore(score);
		}
	}
}
