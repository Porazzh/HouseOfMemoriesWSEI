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
            //Debug.Log("plox dzia�aj");
            //anim = @object.GetComponent<Animation>();
            //anim.Play();
            //Camera.main.orthographicSize = 5f;  
    }

    }
}





/*
public Animation cam;
private void Start()
{
    cam = GetComponent<Animation>();
    foreach (AnimationState state in cam)
    {
        state.speed = 0.5f;
    }

}
*/