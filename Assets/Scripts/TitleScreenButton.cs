using UnityEngine;
using System.Collections;

public class TitleScreenButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Debug.Log("Felt mouse down.");
		Application.LoadLevel ("StoryBoard_scene1");
	}

	void OnMouseUp(){

	}
}
