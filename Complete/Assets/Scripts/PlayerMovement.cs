using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

     public Rigidbody Rb;
    public float forwardforce = 3000f;
    public float sidewayforce = 100f;
	public float jumpforce = 200f;

	private RaycastHit hit = new RaycastHit();
	private bool grounded = false;
	private System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

	// Update is called once per frame
	void FixedUpdate () //use FixedUpdate instead of Update (Unity prefers even though they are both the same)
    {   

        //Add Forward Force
        Rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
		//else if (Input.GetAxisRaw("Horizontal") == 0 ){		
			//Rb.velocity = new Vector3(0, Rb.velocity.y, Rb.velocity.z);
		//}

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


		if (Physics.Raycast (transform.position, Vector3.down, out hit) &! timer.IsRunning) {
			if (hit.distance <= 1) {
				grounded = true;
				timer.Start ();
			}
		}

		if (timer.IsRunning) {
			if (timer.Elapsed.Seconds >= 2) {
				timer.Stop ();
				timer.Reset ();
			}
		}

		if (Input.GetButton("Jump") && grounded)
        {
			grounded = false;
            Rb.AddForce(0, jumpforce * Time.deltaTime, 0, ForceMode.VelocityChange);

            
            
        }
        
    }
 
}