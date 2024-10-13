using StupidTemplate;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class NoClips
    {
        public static void NoClip()
        {
            bool shouldDisableColliders = Settings.rightHanded
                ? ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f
                : ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;

            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();
            foreach (MeshCollider meshCollider in colliders)
            {
                meshCollider.enabled = !shouldDisableColliders;
            }
        }
    }
}
