using UnityEngine;
using System.Collections;

public class ArrowLettersControl : MonoBehaviour {

	public GameObject[] arrows;
	private GameObject thisArrow, instantiate;
	private int random, time;
	private bool isInstantiated;
	private float velocity;

	// Use this for initialization
	void Start () {

		velocity = 10.0f;
		isInstantiated = false;
		time = 100;
		StartCoroutine(Instantiate());
	}
	
	// Update is called once per frame
	void Update () {
		SearchObject ();
		Clicks ();
	}

	void Clicks(){

		if (GameObject.Find ("up")) {
			
			if (Input.GetKeyDown(KeyCode.UpArrow)) { 
				DestroyImmediate (GameObject.FindGameObjectWithTag ("up"));
			}
		}
		
		if (GameObject.Find ("left")) {
			
			if (Input.GetKeyDown(KeyCode.LeftArrow)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("left"));
			}
		}
		
		if (GameObject.Find ("down")) {
			
			if (Input.GetKeyDown(KeyCode.DownArrow)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("down"));
			}
		}
		
		if (GameObject.Find ("right")) {
			
			if (Input.GetKeyDown(KeyCode.RightArrow)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("right"));
			}
		}
	}

	void SearchObject(){

		// SearchArrows
		random = Random.Range (0, 4);
		
		switch (random) {
		case 0:
			thisArrow = arrows [0];
			break;
			
		case 1:
			thisArrow = arrows [1];
			break;
			
		case 2:
			thisArrow = arrows [2];
			break;
			
		case 3:
			thisArrow = arrows [3];
			break;
			
		}

	}



	IEnumerator Instantiate() 
	{
		yield return new WaitForSeconds (1);
		instantiate = Instantiate (thisArrow, transform.position, transform.rotation) as GameObject;
		instantiate.transform.position -= new Vector3 (velocity * Time.deltaTime, 0, 0);
		isInstantiated = true;
		StartCoroutine(Instantiate());
	}



}
