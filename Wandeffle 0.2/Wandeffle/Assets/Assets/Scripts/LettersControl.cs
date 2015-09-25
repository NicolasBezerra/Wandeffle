using UnityEngine;
using System.Collections;

public class LettersControl : MonoBehaviour {

	public GameObject[] letters;
	private GameObject thisLetters, instantiate;
	private int randomL, time;
	private bool isInstantiated;
	
	// Use this for initialization
	void Start () 
	{
		isInstantiated = false;
		time = 100;
		StartCoroutine(Instantiate());
	}
	
	// Update is called once per frame
	void Update () 
	{
		SearchObject ();
		Clicks ();
		
	}
	
	void Clicks()
	{
		if (GameObject.FindGameObjectWithTag ("W")) {
			
			if (Input.GetKeyDown(KeyCode.W)) { 	
				DestroyImmediate (GameObject.FindGameObjectWithTag ("W"));
			}
		}
		
		if (GameObject.FindGameObjectWithTag ("A")) {
			
			if (Input.GetKeyDown(KeyCode.A)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("A"));
			}
		}
		
		if (GameObject.FindGameObjectWithTag ("S")) {

			if (Input.GetKeyDown(KeyCode.S)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("S"));
			}
		}
		
		if (GameObject.FindGameObjectWithTag ("D")) {
			
			if (Input.GetKeyDown(KeyCode.D)) {
				DestroyImmediate(GameObject.FindGameObjectWithTag ("D"));
			}
		}
	}
	
	void SearchObject()
	{
		randomL = Random.Range (0, 4);
		
		switch (randomL) {
		case 0:
			thisLetters = letters [0];
			break;
			
		case 1:
			thisLetters = letters [1];
			break;
			
		case 2:
			thisLetters = letters [2];
			break;
			
		case 3:
			thisLetters = letters [3];
			break;
			
		}
		
	}

	IEnumerator Instantiate() 
	{
		yield return new WaitForSeconds (1);
		instantiate = Instantiate (thisLetters, transform.position, transform.rotation) as GameObject;
		isInstantiated = true;
		StartCoroutine(Instantiate());
	}

}
