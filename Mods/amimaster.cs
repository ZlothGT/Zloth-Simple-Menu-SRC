using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class amimaster
    {
        public static void CheckIFMaster()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                NotifiLib.SendNotification("<color=green>[MASTER]</color> You are master client");
            }
            else
            {
                NotifiLib.SendNotification("<color=red>[MASTER]</color> You are not master client");
            }
            if (PhotonNetwork.InRoom)
            {
                NotifiLib.SendNotification("");
            }
            else
            {
                NotifiLib.SendNotification("<color=red>[ROOM]</color> You are not connected to a room!");
            }
        }
    }
}
