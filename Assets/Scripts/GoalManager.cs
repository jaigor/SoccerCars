using UnityEngine;
using System.Collections;

public class GoalManager : MonoBehaviour {

	public GameObject ball;

	Collider ballCollider;

	void Start () 
	{
		ballCollider = ball.GetComponent<SphereCollider>();
	}
	

	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == ballCollider.tag) 
		{
			Debug.Log (other);
		}
	}
}
