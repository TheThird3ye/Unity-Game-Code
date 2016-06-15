using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {

	public float speed;
	Vector2 offset;

	void Start () {
	
	}

	void Update () {
		offset = new Vector2 (0, Time.time * speed);

		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
