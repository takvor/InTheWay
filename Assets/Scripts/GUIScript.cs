using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
	private bool opossumDrag = false;
	private enum SpritesToPlace{
		Normal_Possum,
		Spike_Possum,
		Bomb_Possum,
		None
	
	};
	//private SpritesToPlace nextSpriteToPlace = SpritesToPlace.None;
	// Use this for initialization
	GameObject clone;
	Vector2 currentMouse;
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		currentMouse  = new Vector3(Input.mousePosition.x,Input.mousePosition.y);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint(currentMouse);
		Vector3 newPos = new Vector3(currentPos.x, currentPos.y,0);


		//transform.position = currentPos;

		if(opossumDrag){
			clone.transform.position = newPos;
			Debug.Log ("Drag The Opossum! " + newPos.x.ToString() + ", " + newPos.y.ToString());
			
			if(Input.GetMouseButtonDown(0)){
				Collider2D[] cols = clone.GetComponents<Collider2D>();
				foreach(Collider2D c in cols){
					c.isTrigger = false; //resets opossum to have collisions
				}
				//Vector3  currentScreenPoint = new Vector3(Input.mousePosition.x,Input.mousePosition.y,90);

				opossumDrag = false;
				//nextSpriteToPlace = SpritesToPlace.None;
			}
		}
	}

	void OnGUI () {



		// Make a first button
		if(GUI.Button (new Rect(Screen.width/8,Screen.height-(Screen.height/8),Screen.width/4,Screen.height/8), "Normal Opossum")){
			//nextSpriteToPlace = SpritesToPlace.Normal_Possum;
			//setClone();
			clone = Instantiate (Resources.Load("Characters/Normal_Opossum"))as GameObject;
			Collider2D[] cols = clone.GetComponents<Collider2D>();
			foreach(Collider2D c in cols){
				c.isTrigger = true; //allows opossum to ignore collisions
			}
			opossumDrag = true;

		}

		// Make a second button
		if(GUI.Button (new Rect((Screen.width/8)*3,Screen.height-(Screen.height/8),Screen.width/4,Screen.height/8), "Spike Opossum")){
			//nextSpriteToPlace = SpritesToPlace.Spike_Possum;
			//setClone();
			clone = Instantiate (Resources.Load("Characters/Spike_Opossum"))as GameObject;
			Collider2D[] cols = clone.GetComponents<Collider2D>();
			foreach(Collider2D c in cols){
				c.isTrigger = true; //allows opossum to ignore collisions
			}
			opossumDrag = true;
		}

		// Make a third button
		if(GUI.Button (new Rect((Screen.width/8)*5,Screen.height-(Screen.height/8),Screen.width/4,Screen.height/8), "Bomb Opossum")){
			//nextSpriteToPlace = SpritesToPlace.Bomb_Possum;
			//setClone();
			clone = Instantiate (Resources.Load("Characters/Bomb_Opossum"))as GameObject;
			Collider2D[] cols = clone.GetComponents<Collider2D>();
			foreach(Collider2D c in cols){
				c.isTrigger = true; //allows opossum to ignore collisions
			}
			opossumDrag = true;
		}
	}

	/*private void setClone(){
		if(nextSpriteToPlace != SpritesToPlace.None){
			Debug.Log ("Opossum was made.");
			clone = Instantiate (Resources.Load("Characters/" + nextSpriteToPlace.ToString()))as GameObject;
		}
	}*/
}