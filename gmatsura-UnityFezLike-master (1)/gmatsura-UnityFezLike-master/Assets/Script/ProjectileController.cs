using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	public float speed;
  private int direction;

	// Use this for initialization
	void Start () {
    this.direction = GameObject.FindWithTag("Player").GetComponent<FezMove>().getDirection();
	}
	
	// Update is called once per frame
	void Update () {
    GetComponent<Rigidbody2D> ().velocity = new Vector2 (this.direction * this.speed, GetComponent<Rigidbody2D> ().velocity.y);
	}

  void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (gameObject);
	}
}
