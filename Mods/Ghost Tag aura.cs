using Photon.Pun;
using System;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class ghost_tag_aura
    {
        public static void ActivateGhostTagAura()
        {
            float closestDistance = 3f;
            VRRig closestRig = null;

            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("GhostSkeleton") &&
                    vrrig != GorillaTagger.Instance.offlineVRRig &&
                    Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position) < closestDistance &&
                    !vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
                {
                    closestDistance = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position);
                    closestRig = vrrig;
                }
            }

            if (closestRig != null)
            {
                GorillaTagger.Instance.leftHandTransform.position = closestRig.transform.position;
                GorillaTagger.Instance.offlineVRRig.transform.position = closestRig.transform.position;
                GorillaTagger.Instance.myVRRig.transform.position = closestRig.transform.position;
            }
        }
    }
}
