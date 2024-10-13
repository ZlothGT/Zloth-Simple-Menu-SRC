using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class flicktag
    {
        public static void flicktagmod()
        {
            RaycastHit raycastHit;
            Vector3 rayOrigin = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position +
                                GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward * 0.1f; // Adjusting the origin slightly forward
            Physics.Raycast(rayOrigin, GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward, out raycastHit);

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
                Vector3 handOffset = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward * 0.5f; // Slightly adjust hand position forward
                GorillaLocomotion.Player.Instance.rightControllerTransform.position = gameObject.transform.position + handOffset;
            }
        }
    }
}
