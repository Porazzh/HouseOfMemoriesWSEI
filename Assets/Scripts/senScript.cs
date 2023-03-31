using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using Unity.VisualScripting;
using static System.Net.Mime.MediaTypeNames;
using UnityEditor.VersionControl;

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

    float fadingTxtAlpha;

    bool waiting = true;

    void Start()
    {
        activeTxt = txt1;
        fadingTxt = txt2;
    }
    private void Update()
    {
        if (waiting) { WaitForUserInput(); }
        else { DisplayMessage(); }
        FadeBackgroundMessage();
    }

    void WaitForUserInput()
    {
        if (messageIdx == messages.Length - 1) { return; } // No more messages

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AdvanceDialogue();
            waiting = false;
        }
    }




    void AdvanceDialogue()
    {
        // Reset the message/char indices for the new message
        messageIdx++;
        charIdx = 0;

        // Clear out the last faded text and reset its alpha
        fadingTxtAlpha = 1f;
        fadingTxt.text = string.Empty;
        fadingTxt.alpha = fadingTxtAlpha;

        // Swap out the active and fading text boxes
        var tmpTxt = activeTxt;
        activeTxt = fadingTxt;
        fadingTxt = tmpTxt;
    }
    void DisplayMessage()
    {
        var message = messages[messageIdx];

        // Allow user to skip typing animation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activeTxt.text = message;
            charIdx = message.Length;
        }

        // Are we done typing this message?
        if (charIdx >= message.Length)
        {
            waiting = true;
            timeSinceLastChar = 0f;
            return;
        }
        // Type the next character if we've waited long enough
        while (timeSinceLastChar >= secondsPerChar)
        {
            activeTxt.text = message.Substring(0, charIdx + 1);
            charIdx++;
            timeSinceLastChar -= secondsPerChar;
        }
        timeSinceLastChar += Time.deltaTime;
    }

    void FadeBackgroundMessage()
    {
        if (fadingTxtAlpha > 0f)
        {
            fadingTxtAlpha -= Mathf.Clamp01((1 / secondsToFade) * Time.deltaTime);
            fadingTxt.alpha = fadingTxtAlpha;
        }
    }

    string[] messages = new[] // Some test messages to display
     {
         "Zapad³eœ w sen",
         "Twoje sny staj¹ siê rzeczywistoœci¹",
         "Przypominasz sobie coraz wiêcej",
         "Skup siê"
     };
}
