using BepInEx;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class wasd_fly
    {
        public static void WASDFly()
        {
            bool arrowR = UnityInput.Current.GetKey(KeyCode.RightArrow);
            bool arrowL = UnityInput.Current.GetKey(KeyCode.LeftArrow);
            bool arrowUp = UnityInput.Current.GetKey(KeyCode.UpArrow);
            bool arrowDown = UnityInput.Current.GetKey(KeyCode.DownArrow);
            bool W = UnityInput.Current.GetKey(KeyCode.W);
            bool A = UnityInput.Current.GetKey(KeyCode.A);
            bool S = UnityInput.Current.GetKey(KeyCode.S);
            bool D = UnityInput.Current.GetKey(KeyCode.D);
            bool Space = UnityInput.Current.GetKey(KeyCode.Space);
            bool ControlL = UnityInput.Current.GetKey(KeyCode.LeftControl);
            bool ControlR = UnityInput.Current.GetKey(KeyCode.RightControl);
            bool rightClick = UnityInput.Current.GetMouseButton(1);

            if (rightClick)
            {
                float mouseX = Input.GetAxis("Mouse X") * 5f;
                GorillaLocomotion.Player.Instance.transform.Rotate(0, mouseX, 0);
            }

            if (W || arrowUp)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 20f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (A || arrowL)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.right * Time.deltaTime * -20f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (S || arrowDown)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * -20f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (D || arrowR)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.right * Time.deltaTime * 20f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (ControlL || ControlR)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.up * Time.deltaTime * -9.6f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (Space)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.up * Time.deltaTime * 15.2f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
