using UnityEngine;
using UnityEngine.SceneManagement;

public class gameloseredirect : MonoBehaviour
{
    public GameObject button;

    public void redirect()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
