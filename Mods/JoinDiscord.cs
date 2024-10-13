using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static Mono.Security.X509.X520;

namespace Zloths_Simple_Menu.Mods
{
    internal class JoinDiscord
    {
        public static void JoinMyDC()
        {
            
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.gg/KpaWGaWE8k",
                UseShellExecute = true 
            });
        }
    }
}