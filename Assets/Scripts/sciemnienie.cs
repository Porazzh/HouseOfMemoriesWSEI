using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sciemnienie : MonoBehaviour
{
    public Animator przejscie;
    public float czasPrzejscia;
    public GameObject offMenu;
    public GameObject onMenu;

    public void zgas()
    {
        StartCoroutine(lightsOut());
    }
    IEnumerator lightsOut()
    {       
        //Play animation
        przejscie.SetTrigger("Sciemnij");
        Debug.Log("sciemnienie");
        yield return new WaitForSeconds(czasPrzejscia);
        offMenu.SetActive(false);
        onMenu.SetActive(true);
        przejscie.SetTrigger("Rozjasnij");

    }
}
