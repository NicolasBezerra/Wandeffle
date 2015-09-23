using UnityEngine;
using System.Collections;

public class sobepassarinho : MonoBehaviour {

	public int velocidade;
		
	// Use this for initialization
	void Start () {
		velocidade = Random.Range (7,10);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (velocidade*Time.deltaTime*-1,0,0);
	}
}
