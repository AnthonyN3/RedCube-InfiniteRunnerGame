using UnityEngine;
using System.Collections;

public class FollowPlayerOnZ : MonoBehaviour {
	
	public Transform player;
	private Vector3 originalPos;
	public float zOffset = 0.0f;

	// Use this for initialization
	void Start () {
		if(player == null){
			player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		}
		originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		originalPos.z = player.position.z + zOffset;
		transform.position = originalPos;
	}
}
