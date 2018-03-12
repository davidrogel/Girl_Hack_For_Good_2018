using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventRadio : IEvent
{
    public enum W_Event
    {
        RADIO,
        CLASE
    }

    public W_Event w_Event;

    public GameObject bubble;

    public float timeBetweenText = 0.5f;
    
    public string[] texts;
    
    public TextMesh text01;
    public TextMesh text02;

    void Awake()
    {
        bubble.SetActive(false);
        if(text01)
            text01.gameObject.SetActive(false);
        if(text02)
            text02.gameObject.SetActive(false);
        //this.gameObject.SetActive(false);
    }

    public override void Run()
    {   
        switch (w_Event)
        {
            case W_Event.RADIO:

                bubble.SetActive(true);
                gameObject.SetActive(true);
                StartCoroutine(RadioEvent());

                break;

            case W_Event.CLASE:

                bubble.SetActive(true);
                gameObject.SetActive(true);
                StartCoroutine(ClaseEvent());

                break;
        }

    }

    IEnumerator ClaseEvent()
    {
        text01.gameObject.SetActive(true);
        text02.gameObject.SetActive(true);

        text01.text = texts[0];
        text02.text = texts[1];

        yield return new WaitForSeconds(timeBetweenText);

        text01.gameObject.SetActive(true);
        text02.gameObject.SetActive(false);

        text01.text = texts[2];

        yield return new WaitForSeconds(timeBetweenText);

        bubble.SetActive(false);
        text01.gameObject.SetActive(false);
        text02.gameObject.SetActive(false);
    }

    IEnumerator RadioEvent()
    {
        text01.gameObject.SetActive(true);
        text02.gameObject.SetActive(false);

        text01.text = texts[0];

        yield return new WaitForSeconds(timeBetweenText);

        text01.gameObject.SetActive(true);
        text02.gameObject.SetActive(true);


        text01.text = texts[1];
        text02.text = texts[2];

        yield return new WaitForSeconds(timeBetweenText);

        text01.text = texts[3];
        text02.text = texts[4];

        yield return new WaitForSeconds(timeBetweenText);

        text01.gameObject.SetActive(true);
        text02.gameObject.SetActive(false);

        text01.text = texts[5];

        yield return new WaitForSeconds(timeBetweenText);

        bubble.SetActive(false);
        text01.gameObject.SetActive(false);
        text02.gameObject.SetActive(false);
    }    
}
