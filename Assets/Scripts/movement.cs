using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2D;

    

    public float moveSpeed;
    private float horizontalMove;
    private float verticalMove;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {

        if(horizontalMove > 0.1f || horizontalMove < 0.1f)
        {
            rb2D.AddForce(new Vector2(horizontalMove * moveSpeed, 0f));
        }else
        {
            rb2D.AddForce(new Vector2(0f, 0f));
        }
        if(verticalMove > 0.1f || verticalMove < 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, verticalMove * moveSpeed));
        }else if(verticalMove == 0f)
        {
            rb2D.AddForce(new Vector2(0f,-moveSpeed));
        }
           
    }
}

