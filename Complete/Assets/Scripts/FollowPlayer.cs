using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    public bool useFollowPlayer = true;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if(player == null)
            player = GameObject.FindGameObjectWithTag("Player").transform;
    }

	// Update is called once per frame
	void Update ()
    {

        if(useFollowPlayer)
         transform.position = player.position + offset;

	}
}
