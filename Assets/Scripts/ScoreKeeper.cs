using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public Text scoreText;
	public Text endScoreText;
	public Text highScoreText;
	public int endScore;
	public int highScore;

	private PlayerController player;


	private void Start () {
		player = FindObjectOfType<PlayerController>();
		UpdateScore ();
	}

	public void UpdateScore () {
		scoreText.text = "Score: " + player.score.ToString ();
		endScoreText.text = player.score.ToString ();
		if (player.score > highScore) {
			highScore = player.score;
			PlayerPrefs.SetInt ("highScore", highScore);
		}
		highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
	}
}
