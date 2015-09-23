using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	public Animator animator;
	int direction;
	float axis;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		axis = Input.GetAxis ("Horizontal");

		if (axis < 0)
			animator.SetInteger ("direction", 0);//direction = 0;
		else if(axis > 0)
			animator.SetInteger ("direction", 1);//direction = 1;
	}
}
