using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public List<Transform> waypoints;
    public float duration=1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float t = Time.time % duration;
        int segment = (int)((t/duration) * (waypoints.Count-1));
        float segmentDuration = duration / (waypoints.Count-1);
        float a = (t - segment * segmentDuration) / segmentDuration;
        transform.position = Vector3.Lerp(waypoints[segment].position, waypoints[segment+1].position, a);
        transform.LookAt(waypoints[segment+1]);
    }
}
