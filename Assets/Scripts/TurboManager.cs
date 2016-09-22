using UnityEngine;
using System.Collections;

public class TurboManager : MonoBehaviour {

	private CarMovement carMovement;
	private float spawnTime = 15f;
	private float timer = 0f;

	void Start () {
		
	}
	
	void Update () {
		timer += Time.deltaTime;
		Respawn ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Car") 
		{
			carMovement = other.gameObject.GetComponent<CarMovement> ();
			carMovement.AddTurbo ();
			timer = 0f;
			this.gameObject.SetActive (false);
		}
	}

	void Respawn()
	{
		if (timer >= spawnTime)
		{
			Debug.Log ("respawn");
			this.gameObject.SetActive (true);
		}
	}
}
