using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private movement move;
    bool dotkn� = false;
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
     
        if (dotyka == true && Input.GetKeyUp(KeyCode.E) && dotkn� == false)
        {
            move.enabled = false;
            dotkn� = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            move.enabled = true;
            dotkn� = false;
        }
        
    }
    private void FixedUpdate()
    {
        if (dotkn� == true)
        {
            rb2D.velocity = new Vector2(0f, 0f);
        }
    }
}
