using System;
using System.IO;
using System.Linq;  
using UnityEngine;
using Photon.Pun;
using StupidTemplate.Notifications;
using Zloths_Simple_Menu.Mods;


namespace Zloths_Simple_Menu.Mods
{
    internal class MaterialLogger
    {
        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string filePath = Path.Combine(desktopPath, "CurrentMaterialLog.txt");

        
        

        public static void LogMaterial()
        {




            if (adminenbled.isadminenabled == true)
            {
                bool rightPrimaryButtonPressed = ControllerInputPoller.instance.rightControllerPrimaryButton;

                if (rightPrimaryButtonPressed)
                {
                    VRRig playerRig = GorillaTagger.Instance.offlineVRRig;
                    if (playerRig != null && playerRig.mainSkin != null && playerRig.mainSkin.material != null)
                    {
                        string materialName = playerRig.mainSkin.material.name;

                        try
                        {
                            File.AppendAllText(filePath, $"Current Material: {materialName} - {DateTime.Now}\n");
                            Debug.Log($"Material '{materialName}' saved to {filePath}");
                        }
                        catch (Exception e)
                        {
                            Debug.LogError($"Failed to write material to file: {e.Message}");
                        }
                    }
                    else
                    {
                        Debug.LogWarning("Player rig or material is null.");
                    }
                }
            }
            else
            {
                NotifiLib.SendNotification("<color=red>[Error] - [Missing Perms]</color> You are not allowed to use this mod!");
            }
        }
    }
}
