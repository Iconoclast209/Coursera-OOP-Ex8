using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    int counter = 0;
    Timer timer;
    EventOne eventOne;
    EventTwo eventTwo;

    private void Awake()
    {
        eventOne = new EventOne();
        eventTwo = new EventTwo();
    }

    void Start()
    {
        timer = GetComponent<Timer>();
        timer.Duration = 1f;
        timer.Run();
        EventManager.AddInvoker(this);
    }

    void Update()
    {
        if(timer.Finished)
        {
            eventOne.Invoke();
            eventTwo.Invoke(counter);
            timer.Run();
            counter++;
        }
    }

    
    public void AddNoArgumentListener(UnityAction listener)
    {
        eventOne.AddListener(listener);
    }

    public void AddIntArgumentListener(UnityAction<int> listenerInt)
    {
        eventTwo.AddListener(listenerInt);
    }
    
}
