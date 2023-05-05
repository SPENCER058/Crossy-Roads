using UnityEngine;
using TMPro;

public class GameOverText : MonoBehaviour
{
	[SerializeField] TMP_Text finalScoreText;

	public void UpdateFinalScoreText (int score) {
		finalScoreText.text = "Final Score: " + score;
	}


}
