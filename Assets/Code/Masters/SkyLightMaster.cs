using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLightMaster : MonoBehaviour
{
    public IntReference time; 

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float rotation = 360f * time / TimeSettings.minutesInADay;
        transform.rotation = Quaternion.AngleAxis(rotation-90, Vector3.right);
    }
}
