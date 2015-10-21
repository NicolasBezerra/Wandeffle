using UnityEngine;
using System.Collections;

public class Arrows : MonoBehaviour {

	private float velocity0, velocity1;
	public int type;
	private GameObject end;
    public static string ArrowsTag;
	// Use this for initialization
	void Start () {
        ArrowsTag = "";
		velocity0 = 4f;
		velocity1 = 4f;
		end =  GameObject.Find("End");
	}

    public static string StateHoldButtomArrows = "NotCanHold";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnconterPoint")
        {
            ArrowsTag = "ArrowCanHold";
            StateHoldButtomArrows = "ArrowCanHold";
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnconterPoint")
        {
            ArrowsTag = "ArrowNotHolded";
            PlayerControll.Life -= 1;
            StateHoldButtomArrows = "NotCanHold";
        }
    }
	// Update is called once per frame
	void Update () {
        gameObject.tag = ArrowsTag;
        print(ArrowsTag);
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
