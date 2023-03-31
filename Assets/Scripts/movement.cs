using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2D;

    

    public float moveSpeed;
    private Vector2 movementDirection;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        rb2D.velocity = movementDirection * Time.deltaTime * moveSpeed;
    }
}

