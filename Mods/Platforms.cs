using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class Platforms
    {

        public static void PlatformsMod()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (!leftPlatformEnabled)
                {
                    leftPlatform = GameObject.CreatePrimitive((PrimitiveType)3);
                    leftPlatform.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, elapsedTime / transitionDuration);
                    leftPlatform.GetComponent<Renderer>().material = new Material(Shader.Find("Sprites/Default"));
                    leftPlatform.transform.localScale = new Vector3(0.28f, 0.015f, 0.38f);
                    leftPlatform.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position + new Vector3(0f, -0.02f, 0f);
                    leftPlatform.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation * Quaternion.Euler(0f, 0f, -90f);
                    leftPlatformEnabled = true;
                }
                if (elapsedTime < transitionDuration)
                {
                    leftPlatform.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, elapsedTime / transitionDuration);
                    elapsedTime += Time.deltaTime;
                    if (elapsedTime >= transitionDuration)
                    {
                        elapsedTime = 0f;
                    }
                }
            }
            else
            {
                if (leftPlatformEnabled)
                {
                    UnityEngine.Object.Destroy(leftPlatform);
                    leftPlatformEnabled = false;
                    return;
                }
            }
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (!rightPlatformEnabled)
                {
                    rightPlatform = GameObject.CreatePrimitive((PrimitiveType)3);
                    rightPlatform.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, elapsedTime / transitionDuration);
                    rightPlatform.GetComponent<Renderer>().material = new Material(Shader.Find("Sprites/Default"));
                    rightPlatform.transform.localScale = new Vector3(0.28f, 0.015f, 0.38f);
                    rightPlatform.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position + new Vector3(0f, -0.02f, 0f);
                    rightPlatform.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation * Quaternion.Euler(0f, 0f, -90f);
                    rightPlatformEnabled = true;
                }
                if (elapsedTime < transitionDuration)
                {
                    rightPlatform.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, elapsedTime / transitionDuration);
                    elapsedTime += Time.deltaTime;
                    if (elapsedTime >= transitionDuration)
                    {
                        elapsedTime = 0f;
                    }
                }
            }
            else
            {
                if (rightPlatformEnabled)
                {
                    UnityEngine.Object.Destroy(rightPlatform);
                    rightPlatformEnabled = false;
                    return;
                }
            }
            if (!ControllerInputPoller.instance.leftGrab)
            {
                UnityEngine.Object.Destroy(leftPlatform);
            }
            if (!ControllerInputPoller.instance.rightGrab)
            {
                UnityEngine.Object.Destroy(rightPlatform);
            }
        }

        public static GameObject leftPlatform;

        public static bool leftPlatformEnabled = false;

        public static GameObject rightPlatform;

        public static bool rightPlatformEnabled = false;

        public bool platformLeft;

        public bool platformRight;

        private static Color startColor = Color.gray;

        private static Color endColor = Color.gray;

        private static float transitionDuration = 1f;

        private static float elapsedTime = 0f;
    }
}
        

