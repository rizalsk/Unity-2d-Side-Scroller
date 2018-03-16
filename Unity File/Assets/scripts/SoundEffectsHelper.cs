using UnityEngine;
using System.Collections;
/// <summary>
/// Creating instance of sounds from code with no effort
/// </summary>
public class SoundEffectsHelper : MonoBehaviour
{
	/// <summary>
	/// Singleton
	/// </summary>
	public static SoundEffectsHelper Instance;
	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;
	public AudioClip gameOverSound;

	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	public void MakeExplosionSound()
	{
		MakeSound(explosionSound);
	}
	public void MakePlayerShotSound()
	{
		MakeSound(playerShotSound);
	}
	public void MakeEnemyShotSound()
	{
		MakeSound(enemyShotSound);
	}

	public void MakeGameOverSound()
	{
		if (gameOverSound != null)
			MakeSound(gameOverSound);
	}
	/// <summary>/// Play a given sound
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.
		//AudioSource.PlayClipAtPoint(originalClip, transform.position);
		AudioSource.PlayClipAtPoint(originalClip, Camera.main.transform.position, 0.2f);//true volume
	}
}