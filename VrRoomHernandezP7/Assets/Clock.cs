using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] GameObject hourHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject secondHand;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateClock", 0, 1);
    }

    void UpdateClock()
    {
        float hourAngle = DateTime.Now.Hour * (360 / 12);
        float minuteAngle = DateTime.Now.Minute * (360 / 60);
        float secondAngle = DateTime.Now.Second * (360 / 60);

        hourHand.transform.localRotation = Quaternion.Euler(hourAngle, 0, 0);
        minuteHand.transform.localRotation = Quaternion.Euler(minuteAngle, 0, 0);
        secondHand.transform.localRotation = Quaternion.Euler(secondAngle, 0, 0);
    }
}

