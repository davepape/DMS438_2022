using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float duration = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float a = Mathf.PingPong(Time.time, duration) / duration;
        Vector3 pos = Vector3.Lerp(point1.position, point2.position, a);
        transform.position = pos;
    }
}
