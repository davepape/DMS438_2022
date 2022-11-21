using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRGrabber : MonoBehaviour
{
    public string otherTag = "";
    private Transform origParent;
    private bool grabbed = false;

    void Start()
    {
        origParent = transform.parent;
    }

    private void Update()
    {
        if ((grabbed) && (SteamVR_Actions._default.GrabGrip[SteamVR_Input_Sources.LeftHand].stateUp))
        {
            transform.parent = origParent;
            grabbed = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == otherTag)
        {
            if (SteamVR_Actions._default.GrabGrip[SteamVR_Input_Sources.LeftHand].stateDown)
            {
                transform.parent = other.transform;
                grabbed = true;
            }            
        }
    }
}
