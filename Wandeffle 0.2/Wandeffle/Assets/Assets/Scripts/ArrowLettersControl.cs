using UnityEngine;
using System.Collections;

public class ArrowLettersControl : MonoBehaviour {

	public GameObject[] arrows,letters;
	private GameObject thisArrow;
	private GameObject thisLetters;
	private int randomA, randomL;
	private bool isInstantiated;
	private float velocityArrows;
	private float velocityLetters;
	private GameObject instantiateA,instantiateL;
	private int time;

	// Use this for initialization
	void Start () {

		isInstantiated = false;
		time = 100;

	}
	
	// Update is called once per frame
	void Update () {
		SearchObject ();

	}

	void SearchObject(){

		// SearchArrows
		randomA = Random.Range (0, 4);
		
		switch (randomA) {
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

		// SearchLetters
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

	void Instantiete(){

		if (!isInstantiated) {
				for (int x = 0; x < time; x++) {
					instantiateA = Instantiate (thisArrow, transform.position, transform.rotation) as GameObject;
					isInstantiated = true;
				}
			}
		}
	}
