using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreGameover : MonoBehaviour {

    public GameObject Scoregameover;
    

	void Start () 
    {
       	
	}
	
	void Update () 
    {
        int scoregameover = PlayerPrefs.GetInt("Player Score");
        Scoregameover.GetComponent<Text>().text = "Score : " + scoregameover.ToString();
	}
}
