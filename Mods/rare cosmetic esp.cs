using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class rare_cosmetic_esp
    {
        public static void CosmeticESP()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    bool showtracersplz = false;
                    UnityEngine.Color thecolor = vrrig.playerColor;
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBADE") || vrrig.concatStringOfCosmeticsAllowed.Contains("LBAGS"))
                    {
                        thecolor = Color.green;
                        showtracersplz = true;
                    }
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBACP"))
                    {
                        thecolor = Color.blue;
                        showtracersplz = true;
                    }
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK"))
                    {
                        thecolor = Color.red;
                        showtracersplz = true;
                    }
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAD"))
                    {
                        thecolor = Color.white;
                        showtracersplz = true;
                    }
                    if (showtracersplz)
                    {
                        GameObject line = new GameObject("Line");
                        LineRenderer liner = line.AddComponent<LineRenderer>();
                        
                        liner.startColor = thecolor; liner.endColor = thecolor; liner.startWidth = 0.025f; liner.endWidth = 0.025f; liner.positionCount = 2; liner.useWorldSpace = true;
                        liner.SetPosition(0, vrrig.transform.position + new Vector3(0f, 9999f, 0f));
                        liner.SetPosition(1, vrrig.transform.position - new Vector3(0f, 9999f, 0f));
                        liner.material.shader = Shader.Find("GUI/Text Shader");
                        UnityEngine.Object.Destroy(line, Time.deltaTime);
                    }
                }
            }
        }
    }
}
