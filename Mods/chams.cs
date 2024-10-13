using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class chams
    {
        public static void CasualChams()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                    vrrig.mainSkin.material.color = vrrig.playerColor;

                }
            }
        }
        public static void GlowChams()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    Material material = vrrig.mainSkin.material;
                    material.shader = Shader.Find("Standard");
                    material.SetColor("_Color", vrrig.playerColor);
                    material.SetColor("_EmissionColor", vrrig.playerColor * 2);
                    material.EnableKeyword("_EMISSION");
                }
            }
        }
        public static void InfectionChams()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    Color theColor = vrrig.playerColor;
                    Color darkOrange = new Color(0.8196f, 0.4392f, 0f);
                    bool isPlayerTagged = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("infected");

                    if (isPlayerTagged && !vrrig.mainSkin.material.name.Contains("infected"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                        vrrig.mainSkin.material.color = theColor;
                    }
                    else if (!isPlayerTagged && vrrig.mainSkin.material.name.Contains("infected"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                        vrrig.mainSkin.material.color = darkOrange;
                    }
                }
            }
        }
        public static void InfectionGlowChams()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    Color playerColor = vrrig.playerColor;
                    Color darkOrange = new Color(0.8196f, 0.4392f, 0f);
                    bool isPlayerTagged = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("infected");

                    Material chamMaterial = vrrig.mainSkin.material;
                    chamMaterial.shader = Shader.Find("Unlit/Color");
                    chamMaterial.EnableKeyword("_EMISSION");

                    if (isPlayerTagged && !vrrig.mainSkin.material.name.Contains("infected"))
                    {
                        chamMaterial.color = playerColor;
                        chamMaterial.SetColor("_EmissionColor", playerColor * 1.5f); 
                    }
                    else if (!isPlayerTagged && vrrig.mainSkin.material.name.Contains("infected"))
                    {
                        chamMaterial.color = darkOrange;
                        chamMaterial.SetColor("_EmissionColor", darkOrange * 1.5f); 
                    }
                }
            }
        }




        public static void GhostChams()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    Color ghostColor = new Color(0.1569f, 0.6588f, 0.5765f); 
                    bool isPlayerGhost = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("GhostSkeleton");

                    if (isPlayerGhost && !vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("Standard");
                        vrrig.mainSkin.material.SetColor("_Color", vrrig.playerColor);
                        vrrig.mainSkin.material.SetFloat("_Glossiness", 0.6f);
                        vrrig.mainSkin.material.EnableKeyword("_EMISSION");
                        vrrig.mainSkin.material.SetColor("_EmissionColor", vrrig.playerColor * 1.5f);
                    }
                    else if (!isPlayerGhost && vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("Standard");
                        vrrig.mainSkin.material.SetColor("_Color", ghostColor);
                        vrrig.mainSkin.material.SetFloat("_Glossiness", 0.6f);
                        vrrig.mainSkin.material.EnableKeyword("_EMISSION");
                        vrrig.mainSkin.material.SetColor("_EmissionColor", ghostColor * 1.5f);
                    }
                }
            }
        }
        public static void GhostChamsMod()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    Color playerColor = vrrig.playerColor;
                    bool isPlayerTagged = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("GhostSkeleton");

                    if (isPlayerTagged && !vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("Standard");
                        vrrig.mainSkin.material.color = playerColor;
                    }
                    else if (!isPlayerTagged && vrrig.mainSkin.material.name.Contains("GhostSkeleton"))
                    {
                        vrrig.mainSkin.material.shader = Shader.Find("Standard");
                        vrrig.mainSkin.material.color = new Color(0.1569f, 0.6588f, 0.5765f); 
                    }
                }
            }
        }

    }
}







