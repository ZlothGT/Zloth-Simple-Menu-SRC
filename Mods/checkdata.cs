using System.IO;
using System.Linq;  
using System.Text;
using UnityEngine;
using Photon.Pun;
using StupidTemplate.Notifications;
using Zloths_Simple_Menu.Mods;

namespace Zloths_Simple_Menu.Mods
{
    internal class GameDataLogger
    {
        
        

        public static void LogGameData()
        {
            
            string currentPlayerID = PhotonNetwork.LocalPlayer.UserId;


            if (adminenbled.isadminenabled == true)
            {
                string filePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "GameDataLog.txt");
                StringBuilder logBuilder = new StringBuilder();

                
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig != null)
                    {
                        string materialName = vrrig.mainSkin.material.name;
                        Vector3 playerPosition = vrrig.transform.position;

                        
                        string shaderName = vrrig.mainSkin.material.shader.name;

                        
                        Component[] components = vrrig.GetComponents<Component>();
                        StringBuilder componentsList = new StringBuilder();
                        foreach (Component component in components)
                        {
                            componentsList.AppendLine(component.GetType().ToString());
                        }

                        logBuilder.AppendLine($"Material: {materialName}");
                        logBuilder.AppendLine($"Shader: {shaderName}");
                        logBuilder.AppendLine($"Position: {playerPosition}");
                        logBuilder.AppendLine("Components:");
                        logBuilder.AppendLine(componentsList.ToString());
                        logBuilder.AppendLine($"Time Logged: {System.DateTime.Now}");
                        logBuilder.AppendLine("--------------------------");
                    }
                }

                
                GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
                foreach (GameObject obj in allObjects)
                {
                    if (obj.name.Contains("Orb")) 
                    {
                        logBuilder.AppendLine($"Special Object Found: {obj.name}");
                        logBuilder.AppendLine($"Position: {obj.transform.position}");
                        logBuilder.AppendLine($"Shader: {obj.GetComponent<Renderer>()?.material.shader.name}");
                        logBuilder.AppendLine("--------------------------");
                    }
                }

                File.WriteAllText(filePath, logBuilder.ToString());
                Debug.Log("Game data successfully logged to " + filePath);
            }
            else
            {
                NotifiLib.SendNotification("<color=red>[Error] - [Missing Perms]</color> You are not allowed to use this mod!");
            }
        }
    }
}
