using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArrowSpawnBehaviour : MonoBehaviour {

	public GameObject [] Arrows;
	GameObject thisArrow;
	int random, score;
	public Text pontos;
	bool isInstantiated;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

		instantiate();
		 
		if (GameObject.FindGameObjectWithTag ("up")) {
			
			if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) { 
				DestroyImmediate (GameObject.FindGameObjectWithTag ("up"));
				isInstantiated = false;
				scoreAdd();
			}
		}

		if (GameObject.FindGameObjectWithTag ("left")) {
			
			if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("left"));
				isInstantiated = false;
				scoreAdd();
			}
		}

		if (GameObject.FindGameObjectWithTag ("down")) {
			
			if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("down"));
				isInstantiated = false;
				scoreAdd();
			}
		}
		
		if (GameObject.FindGameObjectWithTag ("right")) {
			
			if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("right"));
				isInstantiated = false;
				scoreAdd();
			}
		}
	}

	void scoreAdd(){
		score++;
		pontos.text = "Score: " + score.ToString();
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
