using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
	{
		// Add a forward force
		// rb.AddForce(0, 0, forwardForce * Time.deltaTime);	
		if (Input.GetKey ("d")) 
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("w")) 
		{
			rb.AddForce (0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("s")) 
		{
			rb.AddForce (0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
		}
	}
}
