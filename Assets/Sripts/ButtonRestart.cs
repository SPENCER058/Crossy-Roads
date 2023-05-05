using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRestart : MonoBehaviour
{
	public void RestartGame () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
