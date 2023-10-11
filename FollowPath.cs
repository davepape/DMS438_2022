using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public List<Transform> waypoints;
    public float duration=1.0f;
    public bool playOnStart=true;
    public bool loop=true;
    public bool lookForward=true;
    private float startTime=0.0f;
    private bool playing=false;

    void Start()
    {
        if (playOnStart)
            Play();
        transform.position = waypoints[0].position;
        if (lookForward)
            transform.LookAt(waypoints[1]);
    }
        

    void Update()
    {
        if (playing)
            {
            if ((Time.time-startTime >= duration) && (!loop))
                {
                transform.position = waypoints[waypoints.Count-1].position;
                Stop();
                }
            else
                {
                float t = (Time.time - startTime) % duration;
                int segment = (int)((t/duration) * (waypoints.Count-1));
                float segmentDuration = duration / (waypoints.Count-1);
                float a = (t - segment * segmentDuration) / segmentDuration;
                transform.position = Vector3.Lerp(waypoints[segment].position, waypoints[segment+1].position, a);
                if (lookForward)
                    transform.LookAt(waypoints[segment+1]);
                }
            }
    }

    public void Play()
    {
        playing = true;
        startTime = Time.time;
    }

    public void Stop()
    {
        playing = false;
    }
}
