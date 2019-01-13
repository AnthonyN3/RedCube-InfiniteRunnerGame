using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public Rigidbody Rb;
    public BoxCollider boxCollider;
    public Transform plyCamera;
    public GameObject deathCubes; 
    public MeshRenderer meshRender;
    public int deathCubesAmount;

    void Start (){
        Rb = GetComponent<Rigidbody>();
        Rb.useGravity = true;
        if(plyCamera == null)
        {
        plyCamera = Camera.main.transform;
        }

        if(meshRender == null)
        {
            meshRender = gameObject.GetComponent<MeshRenderer>(); 
        }
         meshRender.enabled = true; 
    }

    void Update()
    {
        	if (transform.position.y <= -0.5) {
			FindObjectOfType<GameManager>().Restart();
		}
    }
   
    void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.tag == "Obstacle" )
        {

             Rb.constraints = RigidbodyConstraints.None;
           
            FollowPlayer Boi  = plyCamera.GetComponent<FollowPlayer>();

            //if Boi does not equal null than it will proceed
            if(Boi != null)
                Boi.useFollowPlayer = false;
            else
                Debug.Log("Can not find script BOI");
 
            movement.enabled = false;
            boxCollider.enabled = false; 
            meshRender.enabled = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY ;


            for(int x = 0; x < deathCubesAmount; x++)
            {
                Instantiate(deathCubes, transform.position, Quaternion.identity);
            }

            FindObjectOfType<GameManager>().EndGame();

            }


    }
}
