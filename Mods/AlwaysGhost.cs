using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class GhostVisibility
    {
        public static void Postfix()
        {
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);

            Object.Destroy(gameObject.GetComponent<BoxCollider>());
            gameObject.transform.SetParent(Camera.main.transform, false);
            gameObject.transform.localPosition = new Vector3(0f, 0f, 0.1f);
            gameObject.transform.localScale = new Vector3(5f, 5f, 0f);
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/URPScryGlass");
            gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0f);
        }
    }
}
