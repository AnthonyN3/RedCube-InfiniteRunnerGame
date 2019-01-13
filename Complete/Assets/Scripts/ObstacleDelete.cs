using UnityEngine;
using System.Collections;

public class ObstacleDelete : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(player == null){
			player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		}

		if(transform.position.z + 10 < player.position.z){
			Destroy(this.gameObject);
		}
	
	}
}
