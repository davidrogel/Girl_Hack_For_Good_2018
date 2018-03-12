using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventLuncher : MonoBehaviour
{
    [SerializeField]
    public IEvent attachedEvent;

    public void Lunch()
    {
        attachedEvent.Run();
    }
}
