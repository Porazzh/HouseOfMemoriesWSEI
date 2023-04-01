using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomanim : MonoBehaviour
{
    Animator myAnimationControler;

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationControler.SetBool("zoom", true);
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationControler.SetBool("zoom", false);
        }
    }
    
}

