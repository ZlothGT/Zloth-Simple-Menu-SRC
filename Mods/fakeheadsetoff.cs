using System;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class fakeheadsetoff
    {
        private static bool isFakeOffEnabled = false;

        public static void FakeOff()
        {
            bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;

            if (rightControllerPrimaryButton)
            {
                isFakeOffEnabled = !isFakeOffEnabled;

                if (isFakeOffEnabled)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.Find("PlayerBody").gameObject.SetActive(false); // Hides the actual player body
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                    GorillaTagger.Instance.offlineVRRig.transform.Find("PlayerBody").gameObject.SetActive(true); // Shows the actual player body
                }
            }
        }
    }
}
