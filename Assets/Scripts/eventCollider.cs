using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class eventCollider : MonoBehaviour
{
    public GameObject @object;
    public Animation anim;

    void OnTriggerEnter2D(Collider2D other)
    {
    
    if (other.tag == "Player")
    {
            @object.SetActive(true);
            
    }

    }

void OnTriggerExit2D(Collider2D other)
{
    if (other.tag == "Player")
    {

            @object.SetActive(false);
            
    }
}
}




