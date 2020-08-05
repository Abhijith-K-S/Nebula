//script to identify player win

using UnityEngine;

public class finishline : MonoBehaviour
{
    public gamemanager gameManager;
    public score end;
    

    void OnTriggerEnter()
    {
        gameManager.win();
        end.endgame();
        
    }
}
