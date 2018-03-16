using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour
{
	public AudioSource sound;
	public static MusicController Instance;
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
		PlaySound ();
	}
	void Start(){
	}

	public void PlaySound(){
		sound.Play ();
	}

	public void StopSound(){
		sound.Stop ();
	}
}