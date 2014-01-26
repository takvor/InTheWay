using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
	private bool possumDrag = false;
	private enum SpritesToPlace{
		Fred,
		OtherRealNames,
		None
	
	};
	private SpritesToPlace nextSpriteToPlace = SpritesToPlace.None;
	// Use this for initialization
	GameObject clone;
	Vector2 currentMouse;
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		currentMouse  = new Vector3(Input.mousePosition.x,Input.mousePosition.y);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint(currentMouse);
		Vector3 newPos = new Vector3(currentPos.x, currentPos.y, 90);


		//transform.position = currentPos;

		if(possumDrag){
			clone.transform.position = newPos;
			Debug.Log ("Drag The Possum! " + newPos.x.ToString() + ", " + newPos.y.ToString());
			/*cols = GetComponents<Collider2D>();
			foreach(Collider2D c in cols){
				c.isTrigger = true; //allows possum to ignore collisions
			}*/
			
			if(Input.GetMouseButtonDown(0)){
				Collider2D[] cols = clone.GetComponents<Collider2D>();
				foreach(Collider2D c in cols){
					c.isTrigger = false; //resets possum to have collisions
				}
				//Vector3  currentScreenPoint = new Vector3(Input.mousePosition.x,Input.mousePosition.y,90);

				possumDrag = false;
				nextSpriteToPlace = SpritesToPlace.None;
			}
		}
	}

	void OnGUI () {


		// Make a background box
		GUI.Box(new Rect(Screen.width/16,Screen.height-(Screen.height/8),Screen.width-(Screen.width/8),Screen.height/8), "Menu Box");



		// Make a first button
		if(GUI.Button (new Rect(Screen.width/16,0f,Screen.width/16,Screen.height/8), "Spawn Possum")){ //Screen.height-(Screen.height/8)
			nextSpriteToPlace = SpritesToPlace.Fred;
			setClone();
			Collider2D[] cols = clone.GetComponents<Collider2D>();
			foreach(Collider2D c in cols){
				c.isTrigger = true; //allows possum to ignore collisions
			}
			possumDrag = true;

		}

		// Make a second button
		if(GUI.Button (new Rect((Screen.width/16)*2,Screen.height-(Screen.height/8),Screen.width/16,Screen.height/8), "Button 2")){
			Debug.Log("You clicked me"); //Button function goes here
		}
	}

	private void setClone(){
		if(nextSpriteToPlace != SpritesToPlace.None){
			Debug.Log ("Possum was made.");
			clone = Instantiate (Resources.Load("Characters/" + nextSpriteToPlace.ToString()))as GameObject;
		}
			//clone.name = "Possum 1";
	}
}