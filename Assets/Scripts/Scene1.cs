using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Fadein;
    public GameObject gal1;
    public GameObject Banana;
    public GameObject Textbox;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        Fadein.SetActive(false);
        Banana.SetActive(true);
        yield return new WaitForSeconds(2);
        //Textruta
        Textbox.SetActive(true);
        yield return new WaitForSeconds(2);
        gal1.SetActive(true);
    }
}
