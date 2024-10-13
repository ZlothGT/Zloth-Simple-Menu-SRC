using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class no_more_tos
    {
        public static void RemoveTOSandModIO()
        {
            GameObject.Find("PrivateUIRoom").gameObject.SetActive(false);
            GameObject.Find("ModIOManager").gameObject.SetActive(false);
        }
    }
}
