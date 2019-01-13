using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PAUSE : MonoBehaviour {

	public bool paused;
	public GameObject pauseCanvas;

	// Use this for initialization
	void Start () {
	paused = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
				paused = !paused;			

		// or just do (pause)
		if (paused == true){
			Time.timeScale = 0;
			pauseCanvas.SetActive (true);

		}
		// or just do (!pause)
		else if (paused == false){
			Time.timeScale  = 1;
			pauseCanvas.SetActive(false); 
		}
	}

	public void ButtonMenu (){
		
		SceneManager.LoadScene("MainMenu");


	}


	
	
}
