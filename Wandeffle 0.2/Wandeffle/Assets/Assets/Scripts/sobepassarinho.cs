using UnityEngine;
using System.Collections;

public class sobepassarinho : MonoBehaviour {

	private float velocity0, velocity1;
	public int type;
	private GameObject end;

	// Use this for initialization
	void Start () {
		velocity0 = 4f;
		velocity1 = 4f;
		end =  GameObject.Find("End");
	}

	// Update is called once per frame
	void Update () {

		switch (type) 
		{
			case 0:
				transform.position -= new Vector3 (velocity0 * Time.deltaTime, 0, 0);
				if (this.gameObject.transform.position.x < end.transform.position.x)
					Destroy (this.gameObject);
			break;

			case 1:
				transform.position += new Vector3 (0, velocity1 * Time.deltaTime, 0);
				if (this.gameObject.transform.position.y > end.transform.position.y)
					Destroy (this.gameObject);
			break;
		}
	}
}
