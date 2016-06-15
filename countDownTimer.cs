using UnityEngine;
using System.Collections;

public class countDownTimer : MonoBehaviour {
    float timeRemaining = 45;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
        if(timeRemaining == 0)
        {
            Application.LoadLevel(name);
        }
	}

    void OnGUI(){
        if(timeRemaining > 0){
            GUI.Label(new Rect(0, 0, 200, 100), "Time Remaining : "+(int)timeRemaining);
        }
        else{
            GUI.Label(new Rect(0, 0, 100, 100), "Time's up You Lose");
        }
    }
}
