using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    static Invoker invoker;
    static UnityAction listener;
    static UnityAction<int> intListener;

    public static void AddInvoker(Invoker outsideInvoker)
    {
        invoker = outsideInvoker;
        if(listener != null)
        {
            invoker.AddNoArgumentListener(listener);
        }

    }

    public static void AddListener(UnityAction handler)
    {
        listener = handler;
        if(invoker != null)
        {
            invoker.AddNoArgumentListener(listener);
        }
    }

    public static void AddIntListener(UnityAction<int> intHandler)
    {
        intListener = intHandler;
        if (invoker != null)
        {
            invoker.AddIntArgumentListener(intListener);
        }
    }

}
