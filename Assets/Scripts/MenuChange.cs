using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChange : MonoBehaviour
{
    public GameObject menuOut;
    public GameObject menuIn;

    public void changeMenu()
    {
        menuOut.SetActive(false);
        menuIn.SetActive(true);
        Debug.Log("menuChange z " + menuOut + " na " + menuIn);
    }
}
