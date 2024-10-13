using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class InfectionTracers
    {
        public static void Tracers()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject line = new GameObject("Line");
                    LineRenderer liner = line.AddComponent<LineRenderer>();
                    Color theColor = vrrig.playerColor;

                    Color darkOrange = new Color(0.8196f, 0.4392f, 0f);
                    bool isPlayerTagged = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("infected");

                    if (isPlayerTagged && !vrrig.mainSkin.material.name.Contains("infected"))
                    {
                        liner.startColor = theColor;
                        liner.endColor = theColor;
                        liner.startWidth = 0.01f;
                        liner.endWidth = 0.04f;
                        liner.positionCount = 2;
                        liner.useWorldSpace = true;
                        liner.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                        liner.SetPosition(1, vrrig.transform.position);
                        liner.material.shader = Shader.Find("GUI/Text Shader");
                        UnityEngine.Object.Destroy(line, Time.deltaTime);
                    }
                    else if (!isPlayerTagged && vrrig.mainSkin.material.name.Contains("infected"))
                    {
                        liner.startColor = darkOrange;
                        liner.endColor = darkOrange;
                        liner.startWidth = 0.02f;
                        liner.endWidth = 0.08f;
                        liner.positionCount = 2;
                        liner.useWorldSpace = true;
                        liner.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                        liner.SetPosition(1, vrrig.transform.position);
                        liner.material.shader = Shader.Find("GUI/Text Shader");
                        UnityEngine.Object.Destroy(line, Time.deltaTime);
                    }
                }
            }
        }
    }
}
