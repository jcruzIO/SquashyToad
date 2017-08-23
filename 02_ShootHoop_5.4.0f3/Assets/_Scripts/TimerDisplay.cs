using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour {

	Text text; 
	LevelManager timer; 

	// Use this for initialization
	void Start () {
		timer = FindObjectOfType<LevelManager> (); 
		text = GetComponent<Text> ();  
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time: " + timer.timeTillNextLevel; 
	}
}
