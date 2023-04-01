using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winZegar : MonoBehaviour
{
    odpzegar odpz1;
    odpzegar2 odpz2;
    public bool wygrana = false;
    void Update()
    {
        if (odpz1.odp1 && odpz2.odp2)
        {
            bool wygrana = true;
        }
    }
}
