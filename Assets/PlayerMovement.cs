using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;


public class VRPlayerMovement : MonoBehaviour
{ 
    public float speed = 3.0f;

    public UnityEngine.XR.InputDevice leftJoystick;
    public UnityEngine.XR.InputDevice rightJoystick;

    void Update()
    {
        Vector2 vec2;

        leftJoystick = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.LeftHand);
        rightJoystick = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.RightHand);

        if (leftJoystick.TryReadAxis2DValue(InputHelpers.Axis2D.PrimaryAxis2D, out vec2))
        {
            Vector3 moveDirection = new Vector3(vec2.x, 0, vec2.y);
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }

        Vector2 vec2_rotation;

        if (rightJoystick.TryReadAxis2DValue(InputHelpers.Axis2D.PrimaryAxis2D, out vec2_rotation))
        {
            Vector3 moveDirection = new Vector3(0, vec2_rotation.x, 0);
            transform.Rotate(moveDirection * speed * 20.0f * Time.deltaTime);
        }
    }
}