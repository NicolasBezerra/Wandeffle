using UnityEngine;
using System.Collections;

public class ArrowSpawnBehaviour : MonoBehaviour {

	public GameObject [] Arrows;
	GameObject thisArrow;
	int random, score;
	bool isInstantiated;
	public GameObject positionSpawne;
	public float velocity;
	// Use this for initialization
	void Start () {
		velocity = 10;
	}

	// Update is called once per frame
	void Update () {

		instantiate();
		 
		if (GameObject.Find ("up")) {
			
			if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) { 
				DestroyImmediate (GameObject.Find ("up"));
				isInstantiated = false;
			}
		}

		if (GameObject.Find ("left")) {
			
			if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
				DestroyImmediate(GameObject.Find ("left"));
				isInstantiated = false;
			}
		}

		if (GameObject.Find ("down")) {
			
			if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
				DestroyImmediate(GameObject.Find ("down"));
				isInstantiated = false;
			}
		}
		
		if (GameObject.Find ("right")) {
			
			if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
				DestroyImmediate(GameObject.Find ("right"));
				isInstantiated = false;
			}
		}
	}

	void instantiate()
	{
		random = Random.Range (0,4);

		switch (random)
		{
			case 0:
				thisArrow = Arrows[0];
				break;
				
			case 1:
				thisArrow = Arrows[1];
				break;
				
			case 2:
				thisArrow = Arrows[2];
				break;
				
			case 3:
				thisArrow = Arrows[3];
				break;
			
		}
		
		if (!isInstantiated) {
			Instantiate (thisArrow, this.transform.position, Quaternion.identity);
			isInstantiated = true;
		}
	}
}
