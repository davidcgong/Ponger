using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTest : MonoBehaviour {
    public Rigidbody testBall;
	// Use this for initialization
	void Start () {
        testBall.AddForce(0, 0, 40);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
