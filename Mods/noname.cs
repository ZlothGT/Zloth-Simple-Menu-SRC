using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class noname
    {
        public static void NoNamemod()
        {
            PhotonNetwork.LocalPlayer.NickName = "_______";
            GorillaComputer.instance.currentName = "_______";
            GorillaComputer.instance.savedName = "_______";
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", "_______");
        }
    }
}
