using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class trigfly
    {
        public static void trigflymod()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
