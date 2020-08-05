//gameover script

using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool status = false;

    public GameObject complete;
    public GameObject over;

    public void win()
    {
        complete.SetActive(true);
    }

    public void gameover()
    {   
        if(status == false)
        {
            status = true;
            over.SetActive(true);
            
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
