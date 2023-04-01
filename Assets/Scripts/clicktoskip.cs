using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clicktoskip : MonoBehaviour
{
    public int clicks;
    public GameObject cut1;
    public GameObject cut2;
    public GameObject cut3;
    public GameObject cut4;
    public GameObject cut5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicks++;
        }else
        if (clicks == 0)
        {
            cut1.SetActive(true);
        }else
        if(clicks == 1)
        {
            cut2.SetActive(true);
        }else
        if( clicks == 2) 
        { 
            cut3.SetActive(true);
        }else
        if(clicks==3) 
        { 
            cut4.SetActive(true);
        }else
        if (clicks == 4)
        {
            cut5.SetActive(true);
        }else
        if (clicks == 6)
        {
            SceneManager.LoadScene(1);
        }

    }
}
