using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public void Buttomclicked(string ButtomName)
    {
        if (ButtomName == "Play")
        {
            Application.LoadLevel("game");
        }
        if (ButtomName == "PlayAgain")
        {
            Application.LoadLevel("game");
        }
        if (ButtomName == "Menu")
        {
            Application.LoadLevel("Menu");
        }
    }
}
