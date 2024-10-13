using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class NightTime
    {
        public static void EveningTime()
        {
            BetterDayNightManager.instance.SetTimeOfDay(7);
        }
    }
}
