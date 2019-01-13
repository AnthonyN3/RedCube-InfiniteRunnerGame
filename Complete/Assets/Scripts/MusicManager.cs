using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MusicManager : MonoBehaviour {

	public static MusicManager instance;
	public musicFile[] clips;
	private int previousSceneID = -1;
	private AudioSource audioSource;

	void Awake()
	{	
		if(instance != null && instance!= this)
		{
			Destroy(gameObject);
		}
		instance = this;
		DontDestroyOnLoad(gameObject);

		audioSource = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int levelID) 
	{
		Debug.Log("APPLICAITONLOAD");
		if(levelID != previousSceneID)  
		{
			previousSceneID = levelID;
			if(getMusicFileBySceneName(SceneManager.GetActiveScene().name) != null)
			{
				audioSource.clip = getMusicFileBySceneName(SceneManager.GetActiveScene().name).sceneClip;
				audioSource.Stop();
				audioSource.Play();
			}
		}
	}

	public musicFile getMusicFileBySceneName(string scene) 
	{
		return clips.Where(x => x.sceneName == scene).SingleOrDefault();
	}
}

[System.SerializableAttribute]
public class musicFile 
{
	public string sceneName;
	public AudioClip sceneClip;
}
