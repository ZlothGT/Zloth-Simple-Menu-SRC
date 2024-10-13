using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class JoinZlothCode
    {
        public static void JoinCodeZlothMod()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("ZLOTH_MOD", (JoinType)4);
        }
    }
}


