using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMuteToggle : MonoBehaviour
{
	[SerializeField] Toggle toggle;
	[SerializeField] AudioMixer audioMixer;
	[SerializeField] string MasterVolumeParameter;
	private int mutePref;

	private void Awake () {
		mutePref = PlayerPrefs.GetInt("MUTE");
		toggle.SetIsOnWithoutNotify(mutePref != 0);
	}

	private void Start () {
		audioMixer.GetFloat(MasterVolumeParameter, out var master_db);
		toggle.SetIsOnWithoutNotify(master_db == -80);
	}

	public void SetMute (bool toggleValue) {
		int mute;
		float volumeValue;
		if (toggleValue && mutePref == 0) {
			volumeValue = -80;
			mute = 1;
		} else {
			volumeValue = 0;
			mute = 0;
		}
		audioMixer.SetFloat(MasterVolumeParameter, volumeValue);
		PlayerPrefs.SetInt("MUTE", mute);
		PlayerPrefs.SetFloat("MASTER_VOL", volumeValue);
		PlayerPrefs.Save();
	}

	private void OnDestroy () {
		PlayerPrefs.Save();
	}

}
