using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zmianaKameryEvent")
        { 
            if (Camera.main.orthographicSize == 5f)
            { 
                for( float i = 0; i < 50; i += 1)
                {
                    Camera.main.orthographicSize += 0.1f;
                    new WaitForSeconds(5000f);
                }
            }
            else
            {
                Camera.main.orthographicSize = 5f;
            }
        }
    }
}
