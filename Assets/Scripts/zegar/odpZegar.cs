using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odpzegar : MonoBehaviour
{
    public bool odp1 = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "odp zegar")
        {
            odp1 = true;
        }
        else
        {
            odp1 = false;
        }
    }

}
