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
            //Debug.Log("plox dzia³aj");
            //anim = @object.GetComponent<Animation>();
            //anim.Play();
            //Camera.main.orthographicSize = 5f;  
    }

    }

void OnTriggerExit2D(Collider2D other)
{
    if (other.tag == "Player")
    {


            @object.SetActive(false);
            

          //  Camera.main.orthographicSize = 10f;

    }
}
}



