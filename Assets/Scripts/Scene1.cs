using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Fadein;
    public GameObject TitleFadein;
    public GameObject openMouth1F;
    public GameObject openMouth1;
    public GameObject stunned;
    public GameObject openMouth3;
    public GameObject fingerUp1;
    public GameObject Banana;
    public GameObject Textbox;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject FadeOut;

    void Update()
    {
        textLength = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        // event 0
        openMouth1F.SetActive(false);
        stunned.SetActive(false);
        openMouth3.SetActive(false);
        fingerUp1.SetActive(false);
        openMouth1.SetActive(false);
        yield return new WaitForSeconds(4.4f);
        TitleFadein.SetActive(false);
        Fadein.SetActive(false);
        
        Banana.SetActive(true);
        yield return new WaitForSeconds(2);
        //Textruta
        mainTextObject.SetActive(true);
        textToSpeak = "Dude...";
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint =true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        //event 1
        nextButton.SetActive(false);
        openMouth1F.SetActive(true);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Unknown Yellow Individual";
        textToSpeak = "Sup..."; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(0.4f);
        nextButton.SetActive(true);
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        //event 2
        nextButton.SetActive(false);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Banana-bro";
        textToSpeak = "Who are yo-"; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(0.4f);
        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        //event 3
        nextButton.SetActive(false);
        openMouth1F.SetActive(false);
        openMouth3.SetActive(true);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Guide";
        textToSpeak = "Call me Guide. Im here to bring the two of you along."; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(0.4f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Banana-bro";
        textToSpeak = "Psst... We really gonna go with this random girl? This place is giving me the creeps. I might get brown spots from stress."; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(5.05f);
        openMouth3.SetActive(false);
        stunned.SetActive(true);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(0.4f);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //event 5
        nextButton.SetActive(false);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Guide";
        textToSpeak = "..."; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(0.4f);
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //event 6
        nextButton.SetActive(false);
        stunned.SetActive(false);
        openMouth1.SetActive(true);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Guide";
        textToSpeak = "I can hear you, you know. Anyways, we should get going."; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.4f);
        nextButton.SetActive(true);
        eventPos = 7;
    }

    IEnumerator EventSeven()
    {
        //event 7
        nextButton.SetActive(false);
        openMouth1.SetActive(false);
        fingerUp1.SetActive(true);
        //Viktig kan röra åvan---
        charName.GetComponent<TMPro.TMP_Text>().text = "Guide";
        textToSpeak = "So where do you two wanna go first? That way or *Cough* that other way?"; //Viktig, kan röra---
        Textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(4.4f);
        SceneManager.LoadScene(1);
    }
        
    IEnumerator EventNine()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(5);
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }

        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }

        if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }

        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        
        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }

        if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }

        if (eventPos == 8)
        {
            StartCoroutine(EventSeven());
        }

        if (eventPos == 9)
        {
            StartCoroutine(EventNine());
        }

    }



}
