using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class finish : MonoBehaviour
{
    public inventoryManager inventory;
    public GameObject blackDoor;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (inventory.haveBlueKey == true && Input.GetKeyDown(KeyCode.E))
        {
            blackDoor.SetActive(false);
        }
    }

}
