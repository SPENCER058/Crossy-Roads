using TMPro;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
	[SerializeField] TMP_Text highScoreText;
	int currentHighScore;

	void Awake () {
		currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
		UpdateHighScoreText(currentHighScore);
	}

	public void GetFinalScore (int score) {
		int currentHighScore = PlayerPrefs.GetInt( "HighScore", 0);
		if (score > currentHighScore) {
			PlayerPrefs.SetInt("HighScore", score);
			UpdateHighScoreText(score);
		}
	}

	public void UpdateHighScoreText (int score) {
		highScoreText.text = "High Score: " + score;
	}

	private void OnDestroy () {
		PlayerPrefs.Save();
	}
}
