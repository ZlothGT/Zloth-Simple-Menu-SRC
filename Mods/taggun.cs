using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class taggun
    {
        public static void TagGun()
        {
            RaycastHit raycastHit;
            Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward, out raycastHit);
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            gameObject.transform.position = raycastHit.point;
            gameObject.GetComponent<Renderer>().material.color = Color.gray;
            GameObject.Destroy(gameObject.GetComponent<BoxCollider>());
            GameObject.Destroy(gameObject.GetComponent<Rigidbody>());
            GameObject.Destroy(gameObject.GetComponent<Collider>());
            GameObject.Destroy(gameObject, Time.deltaTime);
            
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1)
            {
                float closestDistance = 5f;
                VRRig closestRig = null;

                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("infected") &&
                        vrrig != GorillaTagger.Instance.offlineVRRig &&
                        Vector3.Distance(GorillaTagger.Instance.offlineVRRig.transform.position, vrrig.transform.position) < closestDistance &&
                        !vrrig.mainSkin.material.name.Contains("fected"))
                    {
                        closestDistance = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position);
                        closestRig = vrrig;
                    }
                }

                if (closestRig != null)
                {
                    GorillaTagger.Instance.leftHandTransform.position = closestRig.transform.position;

                    //GorillaTagger.Instance.offlineVRRig.transform.position = closestRig.transform.position;
                    //GorillaTagger.Instance.myVRRig.transform.position = closestRig.transform.position;
                    Debug.Log("TagAura: Successfully moved to the closest VRRig position.");
                }
                else
                {
                    Debug.LogWarning("TagAura: No suitable VRRig found within the specified distance.");
                }

                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GameObject gameObject5 = GameObject.CreatePrimitive(0);
                UnityEngine.Object.Destroy(gameObject5.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject5.GetComponent<SphereCollider>());
                gameObject5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                gameObject5.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                gameObject5.GetComponent<Renderer>().material.color = new Color(2, 2, 2);
                GameObject gameObject2 = GameObject.CreatePrimitive(0);
                UnityEngine.Object.Destroy(gameObject2.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject2.GetComponent<SphereCollider>());
                gameObject2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                gameObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                gameObject2.GetComponent<Renderer>().material.color = new Color(2, 2, 2);
                UnityEngine.Object.Destroy(gameObject5, Time.deltaTime);
                UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
                GorillaTagger.Instance.leftHandTransform.position = gameObject.transform.position;
                //GorillaLocomotion.Player.Instance.transform.position = closestRig.transform.position;
                GorillaTagger.Instance.offlineVRRig.transform.position = gameObject.transform.position;
                //GorillaTagger.Instance.myVRRig.transform.position = closestRig.transform.position;
                GorillaTagger.Instance.leftHandTransform.position = gameObject.transform.position;
            }

            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;

            }
        }
    }
}
