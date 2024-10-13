using Photon.Pun;
using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class paintbot
    {
        public static void PaintBotMod()
        {
            if (ControllerInputPoller.instance.leftGrab || ControllerInputPoller.instance.rightGrab)
            {
                foreach (SlingshotProjectile projectile in GameObject.FindObjectsOfType<SlingshotProjectile>())
                {
                    if (projectile.projectileOwner == (NetPlayer)PhotonNetwork.LocalPlayer)
                    {
                        projectile.gameObject.transform.position = RigManager.GetRandomVRRig(false).headConstraint.transform.position;
                    }
                }
            }
        }
    }
}
