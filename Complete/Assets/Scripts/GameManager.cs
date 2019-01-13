using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	public bool gamehasended = false;
	public float restartdelay = 2f;
	public GameObject completeUI;

	public void LevelComplete(){
		completeUI.SetActive(true);
	}

	public void YOUWIN(){
		SceneManager.LoadScene("YOUWIN");
	}
	
	public void EndGame (){

		if (gamehasended == false){
			gamehasended = true;
			Invoke("Restart", restartdelay);
		}
	}

		
	public void Restart(){

			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

	}
}
