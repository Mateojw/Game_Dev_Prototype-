using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	public float speed;

	private FacingDirection _myFacingDirection;

	public FacingDirection CmdFacingDirection {

		set{ _myFacingDirection = value;
		}

	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}

	void OnTriggerEnter2D(Collision2D other)
	{
		Destroy (gameObject);
	}
}
