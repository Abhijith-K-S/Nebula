//script to identify player win

using UnityEngine;

public class finishline : MonoBehaviour
{
    public gamemanager gameManager;
    


    void OnTriggerEnter()
    {
        gameManager.win();
    }      

}
