// Super-simple navigation for SteamVR.  Attach this script to a Unity GameObject, and make the SteamVR CameraRig a child of that object.
// Travels in the direction that the left controller is pointing, speed scaled by how much the trigger is pulled.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRNavigator : MonoBehaviour
    {
    public float speed = 3.0f;

    private CharacterController controller;

    void Start()
        {
        controller = GetComponent<CharacterController>();
        }

    void Update()
        {
        Vector3 dir = SteamVR_Actions._default.Pose[SteamVR_Input_Sources.LeftHand].localRotation * Vector3.forward;
        dir *= SteamVR_Actions._default.Squeeze[SteamVR_Input_Sources.LeftHand].axis;
        if (controller)
            controller.SimpleMove(dir * speed);
        else
            transform.localPosition += dir * speed;
        }
}

