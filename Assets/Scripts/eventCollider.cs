using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class eventCollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
{   
    if (other.tag == "Player")
    {   
            Camera.main.orthographicSize = 5f;  
    }

}

void OnTriggerExit2D(Collider2D other)
{
    if (other.tag == "Player")
    {
            Camera.main.orthographicSize = 10f;
    }
}
}




/*
public Animation cam;
private void Start()
{
    cam = GetComponent<Animation>();
    foreach (AnimationState state in cam)
    {
        state.speed = 0.5f;
    }

}
*/