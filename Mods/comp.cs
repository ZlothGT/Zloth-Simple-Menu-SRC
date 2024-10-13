using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class comp
    {
        public static void UnlockCompetitiveQueue()
        {
            GorillaComputer.instance.CompQueueUnlockButtonPress();
        }
    }
}
