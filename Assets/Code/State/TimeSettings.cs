using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TimeSettings")]
public class TimeSettings : ScriptableObject {
    public const int minutesInADay = 1440;
    public int sunriseTime = 360;
    public int sunsetTime = 1040;
    public float pase = 1;

}