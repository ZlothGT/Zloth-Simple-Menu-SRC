using System;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class GhostTracers
    {
        public static void GhostTracersMod()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject line = new GameObject("Line");
                    LineRenderer liner = line.AddComponent<LineRenderer>();
                    Color theColor = vrrig.playerColor;

                    Color taggedColor = new Color(0.1569f, 0.6588f, 0.5765f);  // #28a893
                    bool isPlayerTagged = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("GhostSkeleton");

                    if (isPlayerTagged && !vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
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
                    else if (!isPlayerTagged && vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
                    {
                        liner.startColor = taggedColor;
                        liner.endColor = taggedColor;
                        liner.startWidth = 0.01f;
                        liner.endWidth = 0.04f;
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
