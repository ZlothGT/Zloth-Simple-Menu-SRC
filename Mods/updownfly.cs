using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class FlyMod
    {
        private static float flySpeed = 15f;

        public static void Fly()
        {
            // Fly upwards when holding the right trigger
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                GorillaLocomotion.Player.Instance.transform.position += Vector3.up * flySpeed * Time.deltaTime;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }

            // Fly downwards when holding the left trigger
            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f)
            {
                GorillaLocomotion.Player.Instance.transform.position += Vector3.down * flySpeed * Time.deltaTime;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
