using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomControl : MonoBehaviour
{
    [SerializeField] private Animator MyAnimationControler;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MyAnimationControler.SetBool("zoom", true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MyAnimationControler.SetBool("zoom", false);
        }
        
    }
}

