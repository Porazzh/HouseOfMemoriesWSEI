using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private movement move;
    public Camera camerazeg;
    public Camera cameramain;
    
    bool dotkna = false;
    bool dotyka;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dotyka = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dotyka = false;
    }

    private void Start()
    {
        move = GetComponent<movement>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
     
        if (dotyka == true && Input.GetKeyDown(KeyCode.E) && dotkna == false)
        {
            move.enabled = false;
            dotkna = true;
            cameramain.enabled = false;
            camerazeg.enabled = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            move.enabled = true;
            dotkna = false;
            cameramain.enabled = true;
            camerazeg.enabled = false;
            
        }
        
    }
    private void FixedUpdate()
    {
        if (dotkna == true)
        {
            rb2D.velocity = new Vector2(0f, 0f);
        }
    }
}
