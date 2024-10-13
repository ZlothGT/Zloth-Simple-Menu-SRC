using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class DayTime
    {
        public static void DayTimeMod()
        {
            BetterDayNightManager.instance.SetTimeOfDay(3);
        }
    }
}
