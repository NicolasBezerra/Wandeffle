using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour {

	public Animator animator;
	int direction;
	float axisH, axisV;
    public static bool GameOver;
    public static int Life;
	// Use this for initialization
	void Start () {
        GameOver = false;
        Life = 15;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.FindGameObjectWithTag("Life").GetComponent<Text>().text = "Life : " + Life.ToString();
        if (Life <= 0)
        {
            GameOver = true;
        }
        if(GameOver)
        {
            Application.LoadLevel("GameOver");
        }
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
