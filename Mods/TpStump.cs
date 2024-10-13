using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class TpStump
    {
        private static ControllerInputPoller input;

        public static async Task TPTOSTUMP()
        {
            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                meshCollider.enabled = false;
            }
            GorillaLocomotion.Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.66619f);
            await Task.Delay(325);
            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                meshCollider.enabled = true;
            }
        }
    }
}
