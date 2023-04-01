using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zegar2 : MonoBehaviour
{
    public Camera cameramain;
    private Vector3 mouse_pos;
    public Transform target;
    private Vector3 object_pos;
    private float angle;






    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            mouse_pos = Input.mousePosition;
            mouse_pos.z = -20;
            object_pos = cameramain.WorldToScreenPoint(target.position);
            mouse_pos.x = mouse_pos.x - object_pos.x;
            mouse_pos.y = mouse_pos.y - object_pos.y;
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        }

    }
}
