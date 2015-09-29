using UnityEngine;
using System.Collections;

public class EnconterPoint : MonoBehaviour {

	public static string StateHoldButtom;
	void Start()
	{
		StateHoldButtom = "NotCanDown";
	}
	/*(col.gameObject.tag.Equals("A") || col.gameObject.tag.Equals ("W") || col.gameObject.tag.Equals ("S") || col.gameObject.Equals("D")) &&
		(col.gameObject.tag.Equals ("up") || col.gameObject.tag.Equals ("right") || col.gameObject.tag.Equals ("down") || col.gameObject.tag.Equals ("left"))*/

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "letters"/* && col.gameObject.tag == "arrows"*/)
		{
			StateHoldButtom = "CanDown";
			print (StateHoldButtom);
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.tag == "letters" && col.gameObject.tag == "arrows")
		{
			StateHoldButtom = "NotCanDown";
		}
	}

	void Update()
	{

	}
}
