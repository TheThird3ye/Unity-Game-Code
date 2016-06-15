using UnityEngine;
using System.Collections;

public class EnemyCarMove : MonoBehaviour {

	public float speed = 8f;


	void Start () {
	
	}

	void Update () {

		transform.Translate (new Vector3(0,1,0) * speed * Time.deltaTime);
	}
}
