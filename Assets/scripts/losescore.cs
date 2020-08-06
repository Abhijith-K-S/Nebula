//script to display score on losing the game
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class losescore : MonoBehaviour
{
    public Text finalscore;
    public score GetScore;
    public string tmp;

    void Update()
    {
        finalscore.text = GetScore.returnfinalscore();        
    }
}
