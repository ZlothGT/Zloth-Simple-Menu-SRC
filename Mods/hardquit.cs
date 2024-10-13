using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class hardquit
    {
        public static void PhysicalQuitbox()
        {
            GameObject thequitbox = GameObject.Find("Environment Objects/TriggerZones_Prefab/ZoneTransitions_Prefab/QuitBox");
            GameObject theboxlol = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(theboxlol.GetComponent<Rigidbody>());
            theboxlol.transform.position = thequitbox.transform.position;
            theboxlol.transform.rotation = thequitbox.transform.rotation;
            theboxlol.transform.localScale = thequitbox.transform.localScale;
            
            GameObject.Find("Environment Objects/TriggerZones_Prefab/ZoneTransitions_Prefab/QuitBox").SetActive(false);
        }

    }
}
