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
            Camera.main.orthographicSize = 6f;
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
