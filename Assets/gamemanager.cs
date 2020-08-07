//gameover script

using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool status = false;

    public GameObject complete;
    public GameObject over;
    public score TheEnd;

    public void win()
    {
        complete.SetActive(true);
        TheEnd.gameend();
    }

    public void gameover()
    {   
        if(status == false)
        {
            status = true;
            over.SetActive(true);
            TheEnd.gameend();
        }
     }

    
}
