using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{  
    public void Graj() 
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);

    }
   

   
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
