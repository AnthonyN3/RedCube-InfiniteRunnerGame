using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelComple : MonoBehaviour {

	public void KickScene(){
		Debug.Log("KICKSCENE IS CALLED!!!!!!!!");
		if(MAINMENU.isLastLevel() == false)
		{
			MAINMENU.addLevel(MAINMENU.nextLevelName(SceneManager.GetActiveScene().name));
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
		else 
		{
			SceneManager.LoadScene ("YOUWIN");
		}
	}
}
