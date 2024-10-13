using System;
using System.Collections.Generic;
using System.Text;
using static GorillaLocomotion.Player;

namespace Zloths_Simple_Menu.Mods
{
    internal class no_slip
    {
        

public static void NoSlip()
    {
        MaterialData bluewall = GetMaterial("rockwall2");
        bluewall.slidePercent = 0f;
        MaterialData redwall = GetMaterial("rockwall3"); // maybe red wall mat??
        redwall.slidePercent = 0f;
    }

    public static MaterialData GetMaterial(string uhhcoolmatnameyeah)
    {
        MaterialData matdatyah = new MaterialData();
        matdatyah.matName = uhhcoolmatnameyeah;
        MaterialData matthatwasfound = Instance.materialData.Find(monke => monke.matName == matdatyah.matName);
        return matthatwasfound;
    }
}
}
