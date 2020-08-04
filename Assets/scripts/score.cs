//script for score calculation

using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = (240 -player.position.x).ToString("0");
        
    }
}
