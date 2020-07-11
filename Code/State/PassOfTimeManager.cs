using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PassOfTimeManager : MonoBehaviour {


    public GameEvent SunriseEvent;
    public GameEvent SunsetEvent;
    public IntReference time;
    public TimeSettings timeSettings;

    public void ShiftTime(int delta) {
        int oldTime = time.Value % TimeSettings.minutesInADay;
        time.Variable.ApplyChange(delta);
        int newTime = time.Value % TimeSettings.minutesInADay;
        if(oldTime < timeSettings.sunriseTime && newTime >= timeSettings.sunriseTime)
            SunriseEvent.Raise();
        if(oldTime < timeSettings.sunsetTime && newTime >= timeSettings.sunsetTime)
            SunsetEvent.Raise();
    }

    void Start()
    {
        StartCoroutine(PassTimeCoroutine());
    }

    IEnumerator PassTimeCoroutine()
    {
        while (true) {
            yield return new WaitForSeconds(timeSettings.pase);
            ShiftTime(1);
        }
        
    }
}