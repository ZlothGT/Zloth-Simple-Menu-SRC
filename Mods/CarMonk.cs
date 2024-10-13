using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class CarMonk
    {
        public static void Carmonkey()
        {
            Rigidbody playerRigidbody = GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>();

            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1)
            {
                Vector3 forwardMovement = GorillaLocomotion.Player.Instance.headCollider.transform.forward * 5.5f;
                playerRigidbody.velocity = new Vector3(forwardMovement.x, playerRigidbody.velocity.y, forwardMovement.z);
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                Vector3 backwardMovement = -GorillaLocomotion.Player.Instance.headCollider.transform.forward * 4f;
                playerRigidbody.velocity = new Vector3(backwardMovement.x, playerRigidbody.velocity.y, backwardMovement.z);
            }

            if (ControllerInputPoller.instance.rightControllerIndexFloat < 0.1 && !ControllerInputPoller.instance.rightGrab)
            {
                playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x * 0.9f, playerRigidbody.velocity.y, playerRigidbody.velocity.z * 0.9f);
            }
        }
    }
}
