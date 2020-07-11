using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteHandOrchestrator : MonoBehaviour
{
    public IntReference time;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float rotationDegrees = (time % 60) * 360 / 60;
        transform.localRotation = Quaternion.Euler(Vector3.forward*rotationDegrees);
    }
}
