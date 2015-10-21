using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreInGame : MonoBehaviour {
	
	public GameObject Score;
	public static int score = 0;
    public static int Scoregame = 0;

    void Start()
    {
        score = 0;
    }

	void Update () 
	{
        Scoregame = score;
		Score.GetComponent<Text>().text = "Score : " + Scoregame.ToString();
        if (PlayerControll.GameOver)
        {
            PlayerPrefs.SetInt("Player Score", Scoregame);
        }
	}
}
