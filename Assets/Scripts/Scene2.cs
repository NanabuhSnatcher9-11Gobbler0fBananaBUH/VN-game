using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    public GameObject smile;
    public GameObject openMouth1;
    public GameObject stunned;
    public GameObject openMouth3;
    public GameObject fingerUp1;
    public GameObject Textbox;
    public GameObject banana;
    [SerializeField] int textLength;
    [SerializeField] GameObject Fadein2;
    [SerializeField] GameObject Fadeout2;   
    [SerializeField] GameObject charName;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength; 
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject WindowsButton;
    [SerializeField] GameObject DoorsButton;
    [SerializeField] GameObject FingerButton;
    //buh

    void Start()
    {
        StartCoroutine(EventStarter());
    }



    void Update()
    {
        textLength = TextCreator.charCount;
    }



    IEnumerator EventStarter()
    {
        banana.SetActive(false);
        openMouth1.SetActive(false);
        stunned.SetActive(false);
        openMouth3.SetActive(false);
        fingerUp1.SetActive(false);
        WindowsButton.SetActive(false);
        DoorsButton.SetActive(false);
        FingerButton.SetActive(false);
        // event 0
        Fadein2.SetActive(true);
        yield return new WaitForSeconds(2);
        Fadein2.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = "Guide";
        smile.SetActive(true);
        yield return new WaitForSeconds(2);
        //Textruta
        mainTextObject.SetActive(true);
        textToSpeak = "Uhm, i think we lost the yellow one.";
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        //nextButton.SetActive(true);
        eventPos = 1;
        // Auto start finding banana
        yield return new WaitForSeconds(2);
        nextButton.SetActive(false);
        mainTextObject.SetActive(false);
        WindowsButton.SetActive(true);
        DoorsButton.SetActive(true);
        FingerButton.SetActive(true);
    }

    public void fingerButton()
    {
        StartCoroutine(FingerButtonC());
    }

    IEnumerator FingerButtonC()
    {
        WindowsButton.SetActive(false);
        DoorsButton.SetActive(false);
        FingerButton.SetActive(false);
        // event 0
        charName.GetComponent<TMPro.TMP_Text>().text = "Guide";
        smile.SetActive(true);
        yield return new WaitForSeconds(2);
        //Textruta
        mainTextObject.SetActive(true);
        textToSpeak = "You found him, Good job!";
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        //nextButton.SetActive(true);
        eventPos = 1;
        // Auto start finding banana
        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        WindowsButton.SetActive(false);
        DoorsButton.SetActive(false);
    }
}
