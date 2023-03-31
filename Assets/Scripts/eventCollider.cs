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
        for (int i = 0; i < 50; i++)
        {
            Camera.main.orthographicSize -= 0.1f;
           
        }
    }
}

void OnTriggerExit2D(Collider2D other)
{
    if (other.tag == "Player")
    {
        for (int i = 0; i < 50;i++)
        {
            Camera.main.orthographicSize += 0.1f;

        }

    }
}
}
