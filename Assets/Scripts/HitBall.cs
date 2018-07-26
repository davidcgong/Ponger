using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour {

    public Rigidbody someBody;
    // public float forwardForce = 2000f;
    public float sidewaysForce = 100f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ball")
        {
            Debug.Log("We hit a ball.");
            collision.collider.GetComponent<Rigidbody>().AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
            collision.collider.GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
