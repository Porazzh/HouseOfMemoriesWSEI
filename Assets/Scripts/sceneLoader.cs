using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public Animator przejscie;
    public float czasPrzejscia;
    public void LoadMainLevel() 
    {
        StartCoroutine(LoadLevel(3));
    }
   

   
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation
        przejscie.SetTrigger("Start");
        yield return new WaitForSeconds(czasPrzejscia);
        SceneManager.LoadScene(levelIndex);

    }    
}
