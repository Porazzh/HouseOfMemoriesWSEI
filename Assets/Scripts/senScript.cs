using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using Unity.VisualScripting;

public class senScript : MonoBehaviour
{
    public TMP_Text txt1;
    public TMP_Text txt2;

    public float dzienTyg;

    TMP_Text activeTxt;
    TMP_Text fadingTxt;

    public float secondsPerChar = 0.03f;
    public float secondsToFade = 1.0f;

    int messageIdx; // Which message is displayed
    int charIdx; // Which character of the message is being typed
    float timeSinceLastChar;


    

  

    public void AdvanceDialogue()
    {


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AdvanceDialogue();

        }
    }

    public void changeTxt()
    {

        txt1.text = "jd";

    }
}