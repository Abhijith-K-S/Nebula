//script for score calculation

using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    bool finish = false;
    
    public void endgame()
    {
        finish = true;
    }

    void Update()
    {
        if (finish == false)
        {
            scoreText.text = (240 - player.position.x).ToString("0");   
        }
        
    }
}
