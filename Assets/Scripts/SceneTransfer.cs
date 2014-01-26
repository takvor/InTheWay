using UnityEngine;
using System.Collections;

public class SceneTransfer : MonoBehaviour {

	public string nextSceneString = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		Application.LoadLevel (nextSceneString);
	}
}
