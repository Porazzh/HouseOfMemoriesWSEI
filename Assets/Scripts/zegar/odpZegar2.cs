using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odpzegar2 : MonoBehaviour
{
    public bool odp2 = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "odp zegar2")
        {
            odp2 = true;
        }
        else
        {
            odp2 = false;
        }
    }

}
