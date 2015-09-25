using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	public Animator animator;
	int direction;
	float axisH, axisV;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		axisH = Input.GetAxis ("Horizontal");
		axisV = Input.GetAxis ("Vertical");

		if (axisH < 0)
			animator.SetInteger ("direction", 0);//direction = 0; -> left
		else if(axisH > 0)
			animator.SetInteger ("direction", 1);//direction = 1; -> right
		if (axisV > 0)
			animator.SetInteger ("direction", 2);//direction = 2; -> up
		else if(axisV < 0)
			animator.SetInteger ("direction", 3);//direction = 3; -> down
	}
}
