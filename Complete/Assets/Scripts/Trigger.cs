using UnityEngine;

public class Trigger : MonoBehaviour {

	public GameManager gameManager;
	public GameObject objectPlayer;

	void OnTriggerEnter(Collider player){
		if(player.tag == "Player"){
			objectPlayer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
			gameManager.LevelComplete();
			
		}

	}
}
