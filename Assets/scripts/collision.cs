﻿using UnityEngine;

public class collision : MonoBehaviour

{
    public movement move;

    void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag == "obstacle")
        {
            move.enabled = false;
            FindObjectOfType<gamemanager>().gameover();


        }
        
    }
}
