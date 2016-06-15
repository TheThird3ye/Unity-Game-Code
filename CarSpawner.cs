using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

	public GameObject[] cars;
	int carNo;
	public float maxPos = 2.2f;
	public float delayTimer = 0.5f;
	float timer;

	void Start () {
		timer = delayTimer;

	}

	void Update () {

		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3(Random.Range(-2.2f,2.2f),transform.position.y,transform.position.z);
			carNo = Random.Range (0,5);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}


	}
}
