using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class gravity
    {
        public static void LowGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (6.66f / Time.deltaTime)), (ForceMode)5);
        }

        public static void ZeroGravity()
        {
            Rigidbody playerRigidbody = GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody;
            playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.useGravity = false;
            playerRigidbody.drag = 0f;
        }

    }
}
