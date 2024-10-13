using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class fixrigcolour
    {
        public static void FixRigColors()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig.mainSkin.material.name.Contains("gorilla_body"))
                {
                    vrrig.mainSkin.material.color = vrrig.playerColor;
                }
            }
        }
    }
}
