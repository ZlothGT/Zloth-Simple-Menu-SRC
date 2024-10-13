using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class moderator
    {
        public static void Stick()
        {
            CosmeticsController.CosmeticItem MODSTICK = CosmeticsController.instance.GetItemFromDict("LBAAK.");
            MODSTICK.canTryOn = true;
            CosmeticsController.instance.itemToBuy = MODSTICK;
            CosmeticsController.instance.itemToPurchase = "LBAAK.";
            CosmeticsController.instance.currentCart.Add(MODSTICK);
            CosmeticsController.instance.UpdateShoppingCart();
            CosmeticsController.instance.unlockedArms.Add(MODSTICK);
        }
    }
}
