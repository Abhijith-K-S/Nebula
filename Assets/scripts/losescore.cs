//script to display score on losing the game
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Totalscorefinish : MonoBehaviour
{
    public Text finalscore;
    public score GetScore;
    public string tmp;

    void Update()
    {  
       tmp = GetScore.returnfinalscore();
       finalscore.text = tmp;
    }
}
