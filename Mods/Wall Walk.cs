using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class Wall_Walk
    {
        public static void WallWalk()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.right * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.right * (Time.deltaTime * (-3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (ControllerInputPoller.instance.rightGrab && ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.forward * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }
        }

    }
}
