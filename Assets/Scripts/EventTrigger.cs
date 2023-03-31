using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider2D other)
    {
        if(other.gameObject.name == "trigger")
        {
            Debug.Log("Enter");
            gameObject.GetComponent<Renderer>().Transform.position+=
        }
    }
}
