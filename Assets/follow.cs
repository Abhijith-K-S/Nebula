

using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    public Vector3 gap;

    
    void Update()
    {
        transform.position = player.position + gap;
        
    }


}
