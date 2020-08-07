using UnityEngine;
using UnityEngine.SceneManagement;

public class bactivate : MonoBehaviour
{
    public GameObject Button;

    void Start()
    {
        Invoke("activate", 6.0f);
    }

    public void activate()
    {
        Button.SetActive(true);
        Debug.Log("hello");
    }

    public void Begin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
}
