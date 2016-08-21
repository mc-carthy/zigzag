using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public Text scoreText;

	private PlayerController player;

	private void Start () {
		player = FindObjectOfType<PlayerController>();
		UpdateScore ();
	}

	public void UpdateScore () {
		scoreText.text = "Score: " + player.score.ToString ();
	}
}
