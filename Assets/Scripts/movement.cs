using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    

    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * (Time.deltaTime * 5);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * (Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * (Time.deltaTime * 5);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * (Time.deltaTime * 5);
        }
    }
}

