using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		speed = 10;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (moveUp)) {
			rb.velocity = new Vector2(0,speed);	

		} else if (Input.GetKey (moveDown)) {
			rb.velocity = new Vector2(0,speed *-1);
		} else {
			rb.velocity = new Vector2 (0, 0);
		}

			
	}
}
