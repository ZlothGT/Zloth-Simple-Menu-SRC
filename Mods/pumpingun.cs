using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class PumpingGun
    {
        public static void Gun()
        {
            RaycastHit raycastHit;
            Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.forward, out raycastHit);

            GameObject gunIndicator = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            gunIndicator.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            gunIndicator.transform.position = raycastHit.point;
            gunIndicator.GetComponent<Renderer>().material.color = Color.gray;
            GameObject.Destroy(gunIndicator.GetComponent<Collider>());

            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1)
            {
                GameObject pumpkin = GameObject.Find("JackOLantern");
                Debug.Log(pumpkin != null ? "Pumpkin found!" : "Pumpkin not found!");

                if (pumpkin != null)
                {
                    pumpkin.SetActive(true);
                    pumpkin.transform.position = raycastHit.point;
                    pumpkin.transform.localScale = new Vector3(1f, 1f, 1f);

                    Renderer pumpkinRenderer = pumpkin.GetComponent<Renderer>();
                    if (pumpkinRenderer != null)
                    {
                        // Ensure the material is set to a visible shader
                        pumpkinRenderer.material = new Material(Shader.Find("Standard"));
                        pumpkinRenderer.material.color = Color.yellow; // Set to a visible color
                        pumpkinRenderer.enabled = true;
                    }
                }
            }

            GameObject.Destroy(gunIndicator, Time.deltaTime);
        }
    }
}
