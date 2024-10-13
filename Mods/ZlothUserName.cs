using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class ZlothUserName
    {
        public static void ZlothName()
        {
            PhotonNetwork.LocalPlayer.NickName = "ZLOTHUSER";
            GorillaComputer.instance.currentName = "ZLOTHUSER";
            GorillaComputer.instance.savedName = "ZLOTHUSER";
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", "ZLOTHUSER");
        }
    }
}
