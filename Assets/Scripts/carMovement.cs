using UnityEngine;
using System.Collections;

public class carMovement : MonoBehaviour {

	public float acceleration = 5f;
	public float torque = 5f;

	private float move = 0f;
	private float direction = 0f;

	Rigidbody body;

	void Awake () 
	{
		body = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		move = 0f;
		direction = 0f;
		if (Input.GetKey(KeyCode.W))
		{
			move = 1f;

		}
		if (Input.GetKey(KeyCode.S))
		{
			move = -1f;
		}
		if (Input.GetKey(KeyCode.D))
		{
			direction = 1f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			direction = -1f;
		}
		if (Input.GetKey(KeyCode.Return))
		{
			Jump ();
		}

	}

	void FixedUpdate () 
	{
		Accelerate ();
		Turn ();
	}

	void Accelerate ()
	{
		Vector3 acc = Vector3.up * move * acceleration * Time.deltaTime;
		body.AddRelativeForce (acc);
	}
		
	void Turn ()
	{
		Vector3 trq = Vector3.back * direction * move * body.velocity.magnitude / torque;
		//body.AddRelativeTorque (trq);
		body.rotation *= Quaternion.Euler(trq);
	}

	void Jump ()
	{
		Vector3 acc = Vector3.back * acceleration * Time.deltaTime;
		body.AddRelativeForce (acc);
	}
}
