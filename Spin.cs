using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed=360.0f;
    public Vector3 axis=Vector3.up;
    
    void Start()
    {       
    }

    void Update()
    {
        transform.Rotate(axis, speed*Time.deltaTime);
    }
}
