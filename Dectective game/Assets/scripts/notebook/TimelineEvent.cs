using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineEvent : MonoBehaviour
{
    public string EventName;

    public TimelineEvent(string name)
    {

        this.EventName = name;
    }
}
