using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    //Invoker invoker;

    private void Start()
    {
        //invoker = FindObjectOfType<Camera>().GetComponent<Invoker>();
        //invoker.AddNoArgumentListener(PrintAMessage);
        //invoker.AddIntArgumentListener(PrintIntMessage);
        EventManager.AddListener(PrintAMessage);
        EventManager.AddIntListener(PrintIntMessage);
    }

    public void PrintAMessage()
    {
        Debug.Log("This is a message called by an event handler.");
    }

    public void PrintIntMessage(int i)
    {
        Debug.Log("This is a message called by an event handler with an integer attached:  " + i);
    }
}
