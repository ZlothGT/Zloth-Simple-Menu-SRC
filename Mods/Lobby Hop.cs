using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class Lobby_Hop
    {
        public static async Task LobbyHopMod()
        {
            
            bool flag = PhotonNetwork.InRoom || PhotonNetwork.InLobby;
            if (flag)
            {
                PhotonNetwork.Disconnect();
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
            else
            {
                bool activeSelf4 = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest").activeSelf;
                if (activeSelf4)
                {
                    GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Forest, Tree Exit").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
                }
                bool activeSelf5 = GameObject.Find("Environment Objects/LocalObjects_Prefab/City").activeSelf;
                if (activeSelf5)
                {
                    GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - City Front").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
                }
                bool activeSelf6 = GameObject.Find("Environment Objects/LocalObjects_Prefab/Canyon").activeSelf;
                if (activeSelf6)
                {
                    GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Canyon").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
                }
            }
        }
    }
}
