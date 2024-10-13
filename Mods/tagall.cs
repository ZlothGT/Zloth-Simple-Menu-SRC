using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.XR;
using UnityEngine;
using System.Threading.Tasks;

namespace Zloths_Simple_Menu.Mods
{
    internal class tagall
    {
        public static void ActivateTagAll()
        {
            float closestDistance = 10000000f;
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

                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GameObject gameObject = GameObject.CreatePrimitive(0);
                UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject.GetComponent<SphereCollider>());
                gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                gameObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                gameObject.GetComponent<Renderer>().material.color = new Color(2, 2, 2);
                GameObject gameObject2 = GameObject.CreatePrimitive(0);
                UnityEngine.Object.Destroy(gameObject2.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject2.GetComponent<SphereCollider>());
                gameObject2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                gameObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                gameObject2.GetComponent<Renderer>().material.color = new Color(2, 2, 2);
                UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
                GorillaTagger.Instance.leftHandTransform.position = closestRig.transform.position;
                //GorillaLocomotion.Player.Instance.transform.position = closestRig.transform.position;
                GorillaTagger.Instance.offlineVRRig.transform.position = closestRig.transform.position;
                //GorillaTagger.Instance.myVRRig.transform.position = closestRig.transform.position;
                
                
                
                Debug.Log("TagAura: Successfully moved to the closest VRRig position.");
            }
            else
            {
                Debug.LogWarning("TagAura: No suitable VRRig found within the specified distance.");
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
    

    

