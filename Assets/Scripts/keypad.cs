using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{
    public static string correctCode="6969";
    public static string playerCode = "";
    public static int total = 0;

    private void Update()
    {
        if (total == 4)
        {

        }
    }
    private void OnMouseDown()
    {
        playerCode += gameObject.name;
        total += 1;
    }
}
