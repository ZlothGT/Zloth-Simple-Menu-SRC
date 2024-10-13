using GorillaNetworking;
using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class antireportrandom
    {
        public static async Task AntiReportDisconnectMod()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                float D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                                float threshold = 0.8f;

                                if (D1 < threshold || D2 < threshold)
                                {
                                    PhotonNetwork.Disconnect();
                                    NotifiLib.SendNotification("<color=grey>[</color><color=purple>ANTI-REPORT</color><color=grey>]</color> <color=white>Someone attempted to report you, you are joining a new random public.</color>");
                                    await Task.Delay(1000);
                                    bool flag2 = !PhotonNetwork.InRoom;
                                    if (flag2)
                                    {
                                        bool activeSelf = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest").activeSelf;
                                        if (activeSelf)
                                        {
                                            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Forest, Tree Exit").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
                                        }
                                        bool activeSelf2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/City").activeSelf;
                                        if (activeSelf2)
                                        {
                                            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - City Front").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
                                        }
                                        bool activeSelf3 = GameObject.Find("Environment Objects/LocalObjects_Prefab/Canyon").activeSelf;
                                        if (activeSelf3)
                                        {
                                            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Canyon").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
                                        }
                                    }
                                   
                                } 

                                
                            }
                        }
                    }
                }

            }
            catch { } // Not connected
        }
    }
}

