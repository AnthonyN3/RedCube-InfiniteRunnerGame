using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class MAINMENU : MonoBehaviour {

	public List<levelClass> currentLevels = new List<levelClass>();
	private static List<levelClass> static_currentLevels;
	private static string unlockedLevels = "";

	/// Awake is called when the script instance is being loaded.
	void Awake()
	{
		Time.timeScale = 1;
		static_currentLevels = currentLevels;
		foreach(levelClass lvlClass in static_currentLevels) {
			lvlClass.levelButton.gameObject.SetActive(false);
		}
		addLevel("Level01");
		unlockLevels();
	}

	public static void addLevel(string newLevel) 
	{
		unlockedLevels += newLevel + ":";
	}

	public static void unlockLevels() 
	{
		if(unlockedLevels.Contains(":"))
		{
			string[] lickDick = unlockedLevels.Split(':');
			foreach(string str in lickDick) {
				foreach(levelClass lvlClass in static_currentLevels) {
					if(str.Equals(lvlClass.levelName)) {
						lvlClass.levelButton.gameObject.SetActive(true);
					}
				}
			}
		}
	}

	public void InfinteRunnerScene (){

		SceneManager.LoadScene("Unlimited");

	}

	public void loadLevel(string levelName)
	{
		SceneManager.LoadScene(levelName);
	}

	public static string nextLevelName(string currentLevel)
	{
		for(int i = 0; i < static_currentLevels.Count; i++) {
			if(currentLevel == static_currentLevels[i].levelName){
				return(static_currentLevels[i+1].levelName);
			}
		}
		return "";
	}

	public static int currentLevelIndex(string currentLevel) 
	{
		for(int i = 0; i < static_currentLevels.Count; i++) {
			if(currentLevel == static_currentLevels[i].levelName) {
				return i;
			}
		}

		return -1;
	}

	public static bool isLastLevel()
	{
		if(currentLevelIndex(SceneManager.GetActiveScene().name) == static_currentLevels.Count-1) {
			return true;
		} else {
			return false;
		}
	}

	public void SlowMotion(){

		SceneManager.LoadScene("SlowMo Lvl01");
	}

	public void MainMenu(){

		SceneManager.LoadScene("MainMenu");
	}

	public void Instructions (){

		SceneManager.LoadScene("Instructions");
	}

	public void MissionMenu(){

		SceneManager.LoadScene("MissionMenu");
	}

	public void ExitGame(){

		Application.Quit();
	}
}

[System.SerializableAttribute]
public class levelClass 
{
	public string levelName;
	public GameObject levelButton;
}
