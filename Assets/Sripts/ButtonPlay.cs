using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
	[SerializeField] string sceneName;

	public void GoToScene () {
		SceneManager.LoadScene(sceneName);
	}
}
