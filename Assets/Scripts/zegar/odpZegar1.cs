using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odpZegar1 : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private movement move;
    public Camera camerazeg;
    public Camera cameramain;


    bool tak = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        tak = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        tak = false;
    }
}
