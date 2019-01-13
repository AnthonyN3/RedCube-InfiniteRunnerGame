using UnityEngine;
using System.Collections;

public class SlowMoMovement : MonoBehaviour {

	public Rigidbody Rb;
    public float forwardforce = 300f;
    public float sidewayforce = 44400f;

	private float savedForcedVelocity;

	// Update is called once per frame
	void FixedUpdate () //use FixedUpdate instead of Update (Unity prefers even though they are both the same)
    {   

    //     //Add Forward Force
    //     if(Input.anyKey)
	// 		Rb.AddForce(0, 0, forwardforce * Time.deltaTime);

    //     if (Input.GetAxisRaw("Horizontal") > 0)
    //     {
    //         Rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			
	// 		if(updatedVelocity)
	// 		{
	// 			updatedVelocity = false;
	// 			Rb.velocity = new Vector3(0, 0, savedForcedVelocity);
	// 		}
    //     }
	// 	else if (Input.GetAxisRaw("Horizontal") < 0)
    //     {
    //         Rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			
	// 		if(updatedVelocity)
	// 		{
	// 			updatedVelocity = false;
	// 			Rb.velocity = new Vector3(0, 0, savedForcedVelocity);
	// 		}
    //     }
	// 	else if (Input.GetButton("Jump") && grounded)
    //     {
	// 		grounded = false;
    //         Rb.AddForce(0, jumpforce * Time.deltaTime, 0, ForceMode.VelocityChange);
    //    }
	// 	else 
	// 	{	
	// 		if(!updatedVelocity)
	// 		{
	// 			updatedVelocity = true;
	// 			savedForcedVelocity = Rb.velocity.z;
	// 			Rb.velocity = Vector3.zero; // new Vector3(0,0,25); Vector3.zero;
	// 		}
	// 	}

        forwardforce = 2000 + (8500 * Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        sidewayforce = 6000f;
		Rb.AddForce(this.sidewayforce * Time.fixedDeltaTime * Input.GetAxisRaw("Horizontal"), 0, forwardforce * Time.fixedDeltaTime, ForceMode.Acceleration);


		// if (Physics.Raycast (transform.position, Vector3.down, out hit) &! timer.IsRunning) {
		// 	if (hit.distance <= 1) {
		// 		grounded = true;
		// 		timer.Start ();
		// 	}
		// }

		// if (timer.IsRunning) {
		// 	if (timer.Elapsed.Seconds >= 2) {
		// 		timer.Stop ();
		// 		timer.Reset ();
		// 	}
		// }

        
    }
 
}