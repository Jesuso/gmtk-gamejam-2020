using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourHandMaster : MonoBehaviour
{
    public IntReference time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 360f * time / (TimeSettings.minutesInADay/2);
        transform.localRotation = Quaternion.Euler(Vector3.forward*rotation);
    }
}
