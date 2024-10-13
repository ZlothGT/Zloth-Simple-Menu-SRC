/*
using Pathfinding;
using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class StickPlats
    {
        public static void WorldScale(GameObject obj, Vector3 targetWorldScale)
        {
            Vector3 parentScale = obj.transform.parent.lossyScale;
            obj.transform.localScale = new Vector3(
                targetWorldScale.x / parentScale.x,
                targetWorldScale.y / parentScale.y,
                targetWorldScale.z / parentScale.z
            );
        }
        public static void FixStickyCollidersL(GameObject leftPlatform)
        {
            Vector3[] localPositions = new Vector3[]
            {
        new Vector3(0, 1f, 0),
        new Vector3(0, -1f, 0),
        new Vector3(1f, 0, 0),
        new Vector3(-1f, 0, 0),
        new Vector3(0, 0, 1f),
        new Vector3(0, 0, -1f)
            };
            Quaternion[] localRotations = new Quaternion[]
            {
        Quaternion.Euler(90, 0, 0),
        Quaternion.Euler(-90, 0, 0),
        Quaternion.Euler(0, -90, 0),
        Quaternion.Euler(0, 90, 0),
        Quaternion.identity,
        Quaternion.Euler(0, 180, 0)
            };
            for (int i = 0; i < localPositions.Length; i++)
            {
                GameObject side = GameObject.CreatePrimitive(PrimitiveType.Cube);
                try
                {
                    if (leftPlatform.GetComponent<GorillaSurfaceOverride>() != null)
                    {
                        side.AddComponent<GorillaSurfaceOverride>().overrideIndex = leftPlatform.GetComponent<GorillaSurfaceOverride>().overrideIndex;
                    }
                }
                catch { }
                float size = 0.025f;
                side.transform.SetParent(leftPlatform.transform);
                side.transform.position = localPositions[i] * (size / 2);
                side.transform.rotation = localRotations[i];
                WorldScale(side, new Vector3(size, size, 0.01f));
                side.GetComponent<Renderer>().enabled = false;
            }
        }
        public static void FixStickyCollidersR(GameObject rightPlatform)
        {
            Vector3[] localPositions = new Vector3[]
            {
        new Vector3(0, 1f, 0),
        new Vector3(0, -1f, 0),
        new Vector3(1f, 0, 0),
        new Vector3(-1f, 0, 0),
        new Vector3(0, 0, 1f),
        new Vector3(0, 0, -1f)
            };
            Quaternion[] localRotations = new Quaternion[]
            {
        Quaternion.Euler(90, 0, 0),
        Quaternion.Euler(-90, 0, 0),
        Quaternion.Euler(0, -90, 0),
        Quaternion.Euler(0, 90, 0),
        Quaternion.identity,
        Quaternion.Euler(0, 180, 0)
            };
            for (int i = 0; i < localPositions.Length; i++)
            {
                GameObject side = GameObject.CreatePrimitive(PrimitiveType.Cube);
                try
                {
                    if (rightPlatform.GetComponent<GorillaSurfaceOverride>() != null)
                    {
                        side.AddComponent<GorillaSurfaceOverride>().overrideIndex = rightPlatform.GetComponent<GorillaSurfaceOverride>().overrideIndex;
                    }
                }
                catch { }
                float size = 0.025f;
                side.transform.SetParent(rightPlatform.transform);
                side.transform.position = localPositions[i] * (size / 2);
                side.transform.rotation = localRotations[i];
                WorldScale(side, new Vector3(size, size, 0.01f));
                side.GetComponent<Renderer>().enabled = false;
            }
        }


        public static void PlatformsMod()
        {
            // Left hand platform creation and sticky handling
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (!leftPlatformEnabled)
                {
                    leftPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    leftPlatform.GetComponent<Renderer>().material.color = Color.gray;
                    leftPlatform.GetComponent<Renderer>().material = new Material(Shader.Find("Sprites/Default"));
                    leftPlatform.transform.localScale = new Vector3(0.6f, 0.1f, 0.6f);  // Larger hitbox for stability
                    leftPlatform.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position + new Vector3(0f, -0.02f, 0f);
                    leftPlatform.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation * Quaternion.Euler(0f, 0f, -90f);

                    // Adding sticky collision
                    BoxCollider collider = leftPlatform.AddComponent<BoxCollider>();
                    collider.isTrigger = true; // Makes it a trigger

                    Rigidbody rb = leftPlatform.AddComponent<Rigidbody>();
                    rb.isKinematic = true;

                    leftPlatform.AddComponent<StickyPlatform>();  // Custom script for stickiness

                    leftPlatformEnabled = true;
                }
            }
            else
            {
                if (leftPlatformEnabled)
                {
                    UnityEngine.Object.Destroy(leftPlatform);
                    leftPlatformEnabled = false;
                }
            }

            // Right hand platform creation and sticky handling
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (!rightPlatformEnabled)
                {
                    rightPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    rightPlatform.GetComponent<Renderer>().material.color = Color.gray;
                    rightPlatform.GetComponent<Renderer>().material = new Material(Shader.Find("Sprites/Default"));
                    rightPlatform.transform.localScale = new Vector3(0.6f, 0.1f, 0.6f);  // Larger hitbox for stability
                    rightPlatform.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position + new Vector3(0f, -0.02f, 0f);
                    rightPlatform.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation * Quaternion.Euler(0f, 0f, -90f);

                    BoxCollider collider = rightPlatform.AddComponent<BoxCollider>();
                    collider.isTrigger = true; // Makes it a trigger

                    Rigidbody rb = rightPlatform.AddComponent<Rigidbody>();
                    rb.isKinematic = true;

                    rightPlatform.AddComponent<StickyPlatform>();  // Custom script for stickiness

                    rightPlatformEnabled = true;
                }
            }
            else
            {
                if (rightPlatformEnabled)
                {
                    UnityEngine.Object.Destroy(rightPlatform);
                    rightPlatformEnabled = false;
                }
            }
        }

        // Custom sticky script
        public class StickyPlatform : MonoBehaviour
        {
            private void OnTriggerEnter(Collider other)
            {
                if (other.CompareTag("PlayerHand")) // Ensure this tag is applied to hands
                {
                    other.transform.SetParent(transform);  // Stick hand to platform
                }
            }

            private void OnTriggerExit(Collider other)
            {
                if (other.CompareTag("PlayerHand"))
                {
                    other.transform.SetParent(null);  // Release hand when exiting
                }
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


*/