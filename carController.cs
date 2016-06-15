using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

public float power = 5;
public float maxspeed = 10;
public float turnpower = 2;
public float friction = 3;
public Vector2 curspeed ;
Rigidbody2D rigidbody2D;

// Use this for initialization
void Start () {
	rigidbody2D = GetComponent<Rigidbody2D>();
}


void FixedUpdate()
{
	curspeed = new Vector2(rigidbody2D.velocity.x,    rigidbody2D.velocity.y);

	if (curspeed.magnitude > maxspeed)
	{
		curspeed = curspeed.normalized;
		curspeed *= maxspeed;
	}

	if (Input.GetKey(KeyCode.W))
	{
		rigidbody2D.AddForce(transform.up * power);
		rigidbody2D.drag = friction;
	}
	if (Input.GetKey(KeyCode.S))
	{
		rigidbody2D.AddForce(-(transform.up) * (power/2));
		rigidbody2D.drag = friction;
	}
	if (Input.GetKey(KeyCode.A))
	{
		transform.Rotate(Vector3.forward * turnpower);
	}
	if (Input.GetKey(KeyCode.D))
	{
		transform.Rotate(Vector3.forward * -turnpower);
	}

	noGas();

}

void noGas()
{
	bool gas;
	if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
	{
		gas = true;
	}
	else
	{
		gas = false;
	}

	if (!gas)
	{
		rigidbody2D.drag = friction * 2;
	}
}
	void OnCollisionEnter2D(Collision2D col)
{
		if (col.gameObject.tag == "Enemy Car") 
		{
			Destroy (gameObject);
		}
}

}