using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D rb;
	void Start () {
        float randNumber = Random.Range(0, 1);
        rb = GetComponent<Rigidbody2D>();

        if(randNumber < 0.5)
        {
            rb.AddForce(new Vector2(80, 10));
  
        }
        else
        {
            rb.AddForce(new Vector2(-80, -10));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.collider.tag == "Player")
        {
            //rb.velocity = rb.velocity.y / 2 + colInfo.rigidbody.velocity.y/3;
        }
    }
}
