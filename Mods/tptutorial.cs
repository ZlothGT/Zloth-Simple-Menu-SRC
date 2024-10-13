using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class tptutorial
    {
        public static async Task TPTOTUTORIAL()
        {
            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                meshCollider.enabled = false;
            }
            GorillaLocomotion.Player.Instance.transform.position = new Vector3(-86.119f, 37.564f, -67.84005f);
            await Task.Delay(600);
            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                meshCollider.enabled = true;
            }
        }
    }
}
