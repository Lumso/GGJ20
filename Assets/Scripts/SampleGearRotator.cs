using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGearRotator : MonoBehaviour
{
    public float rotationSpeed;
    

    void Update()
    {
        this.transform.Rotate(0f, 0f, rotationSpeed);
    }
}
