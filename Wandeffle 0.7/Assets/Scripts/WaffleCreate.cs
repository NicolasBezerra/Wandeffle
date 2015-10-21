using UnityEngine;
using System.Collections;

public class WaffleCreate : MonoBehaviour {

    public GameObject waffle;
	
	void Update () {
        Instantiate(waffle, new Vector3(Random.Range(-57, 59), Random.Range(-37, 39), 0), waffle.transform.rotation);
	
	}
}
