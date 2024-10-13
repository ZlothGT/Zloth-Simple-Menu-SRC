using System;
using System.Collections.Generic;
using System.Text;

namespace Zloths_Simple_Menu.Mods
{
    internal class fake_oc
    {
        public static void FakeOcMod()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
            }
        }
    }
}


