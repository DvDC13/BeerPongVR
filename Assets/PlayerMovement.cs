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
            Debug.Log(vec2);
            Vector3 moveDirection = new Vector3(vec2.x, 0, vec2.y);
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }

        Vector3 velocity;

        if (leftJoystick.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out velocity))
        {
            Debug.Log(string.Format( "{0}, {1}, {2}", velocity.x, velocity.y, velocity.z));
        }
    }
}