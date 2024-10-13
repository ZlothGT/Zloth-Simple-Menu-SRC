using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Linq;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class adminenbled : MonoBehaviour
    {
        internal static bool isadminenabled; 

        private void Start()
        {
            admincheck(); 
        }

        private static readonly string[] allowedPlayerIDs = { " ", "0", " " };
        private static bool hasRun = false;

        public static void admincheck()
        {
            if (hasRun) return;
            hasRun = true;

            string currentPlayerID = PhotonNetwork.LocalPlayer.UserId;

            if (Array.Exists(allowedPlayerIDs, id => id.Equals(currentPlayerID, StringComparison.Ordinal)))
            {
                isadminenabled = true;
                NotifiLib.SendNotification("<color=red>[OWNER]</color> Welcome ZLOTH, admin mods have been enabled");
            }
            else
            {
                isadminenabled = false;
                NotifiLib.SendNotification("<color=red>[USER] </color> All mods have loaded successfully!");
            }
        }
    }
}
