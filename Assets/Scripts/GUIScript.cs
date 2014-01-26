using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(Screen.width/16,Screen.height-(Screen.height/8),Screen.width-(Screen.width/8),Screen.height/8), "Menu Box");

		// Make a first button
		if(GUI.Button (new Rect(Screen.width/16,Screen.height-(Screen.height/8),Screen.width/16,Screen.height/8), "Button 1")){
			GameObject clone = Instantiate (Resources.Load("Characters/Duck"))as GameObject; //Button function goes here
			clone.name = "Duck 1";
			clone.transform.position = new Vector3(0f,0f,0f);
		}

		// Make a second button
		if(GUI.Button (new Rect((Screen.width/16)*2,Screen.height-(Screen.height/8),Screen.width/16,Screen.height/8), "Button 2")){
			Debug.Log("You clicked me"); //Button function goes here
		}
	}
}