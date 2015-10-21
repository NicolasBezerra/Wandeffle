using UnityEngine;
using System.Collections;

public class Waffle : MonoBehaviour {

	void Update () 
    {
        transform.position += new Vector3(0.1f, 0.1f, 0);
        if (transform.position.y > 85)
        {
            Destroy(gameObject);
        }
	}
}
