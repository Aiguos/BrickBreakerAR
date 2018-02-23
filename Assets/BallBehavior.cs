using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 spawn;

	// Use this for initialization
	void Start ()
	{
	    rb = GetComponent<Rigidbody>();
	    spawn = transform.position;
        resetBall();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

    public void resetBall()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = spawn;
        rb.AddForce(Vector3.left * 40f, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Zone")
        {
            resetBall();
        }
    }
}
