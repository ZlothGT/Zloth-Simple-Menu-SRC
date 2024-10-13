using Photon.Pun;
using StupidTemplate.Classes;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class tag_aura
    {
        public static void ActivateTagAura()
        {
            float closestDistance = 3f;
            VRRig closestRig = null;

            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("infected") &&
                    vrrig != GorillaTagger.Instance.offlineVRRig &&
                    Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position) < closestDistance &&
                    !vrrig.mainSkin.material.name.Contains("fected"))
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
                Debug.Log("TagAura: Successfully moved to the closest VRRig position.");
            }
            else
            {
                Debug.LogWarning("TagAura: No suitable VRRig found within the specified distance.");
            }
        }
    }
}
        

