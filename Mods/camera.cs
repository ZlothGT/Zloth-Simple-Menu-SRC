using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class CameraManager
    {
        private static Camera pcCamera;
        private static bool isFirstPerson = false;

        public static void EnableFirstPerson()
        {
            if (pcCamera == null)
            {
                pcCamera = Camera.main;
            }

            Transform headTransform = GorillaTagger.Instance.offlineVRRig.headConstraint; // Replace with the correct reference

            pcCamera.transform.position = headTransform.position;
            pcCamera.transform.rotation = headTransform.rotation;
            pcCamera.fieldOfView = 90;
            isFirstPerson = true;
        }

        public static void EnableThirdPerson()
        {
            if (pcCamera == null)
            {
                pcCamera = Camera.main;
            }

            pcCamera.transform.position = new Vector3(0, 2.0f, -4.0f);
            pcCamera.transform.rotation = Quaternion.Euler(15, 0, 0);
            pcCamera.fieldOfView = 60;
            isFirstPerson = false;
        }

        public static void ToggleCameraMode()
        {
            if (isFirstPerson)
            {
                EnableThirdPerson();
            }
            else
            {
                EnableFirstPerson();
            }
        }
    }
}
