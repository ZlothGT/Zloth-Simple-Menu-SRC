using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using StupidTemplate.Classes;
using Zloths_Simple_Menu.Mods;


namespace Zloths_Simple_Menu.Mods
{
    internal class lucy_mods
    {

        public static void SpawnBlueLucy()
        {
            HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
            if (hgc.IsMine)
            {
                hgc.timeGongStarted = Time.time;
                hgc.currentState = HalloweenGhostChaser.ChaseState.Gong;
                hgc.isSummoned = false;
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }

        public static void SpawnRedLucy()
        {
            HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
            if (hgc.IsMine)
            {
                hgc.timeGongStarted = 0f;
                hgc.currentState = HalloweenGhostChaser.ChaseState.Gong;
                hgc.isSummoned = true;
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }

        public static void DespawnLucy()
        {
            HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
            if (hgc.IsMine)
            {
                hgc.currentState = HalloweenGhostChaser.ChaseState.Dormant;
                hgc.isSummoned = false;
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }

        public static void LucyChaseSelf()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit raycastHit;
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward, out raycastHit);
                GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

                gameObject.transform.position = raycastHit.point;
                gameObject.GetComponent<Renderer>().material.color = Color.gray;
                GameObject.Destroy(gameObject.GetComponent<BoxCollider>());
                GameObject.Destroy(gameObject.GetComponent<Rigidbody>());
                GameObject.Destroy(gameObject.GetComponent<Collider>());
                GameObject.Destroy(gameObject, Time.deltaTime);

                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                {
                    HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
                    if (hgc.IsMine)
                    {
                        VRRig possibly = raycastHit.collider.GetComponentInParent<VRRig>();
                        if (possibly && possibly != GorillaTagger.Instance.offlineVRRig)
                        {
                            hgc.currentState = HalloweenGhostChaser.ChaseState.Chasing;
                            hgc.targetPlayer = NetworkSystem.Instance.LocalPlayer;
                        }
                    }
                    else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
                }
            }
        }



        private static float timethingidk = 0f;
        public static void SpazLucy()
        {
            HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
            if (hgc.IsMine)
            {
                if (Time.time > timethingidk)
                {
                    hgc.timeGongStarted = Time.time;
                    hgc.currentState = hgc.currentState == HalloweenGhostChaser.ChaseState.Dormant ? HalloweenGhostChaser.ChaseState.Gong : HalloweenGhostChaser.ChaseState.Dormant;
                    timethingidk = Time.time + 0.1f;
                }
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }

        public static void FastLucy()
        {
            HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
            if (hgc.IsMine)
            {
                hgc.currentSpeed = 10f;
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }
        public static void SlowLucy()
        {
            HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
            if (hgc.IsMine)
            {
                hgc.currentSpeed = 1f;
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }
        public static void LucyAttackSelf()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit raycastHit;
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward, out raycastHit);
                GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

                gameObject.transform.position = raycastHit.point;
                gameObject.GetComponent<Renderer>().material.color = Color.gray;
                GameObject.Destroy(gameObject.GetComponent<BoxCollider>());
                GameObject.Destroy(gameObject.GetComponent<Rigidbody>());
                GameObject.Destroy(gameObject.GetComponent<Collider>());
                GameObject.Destroy(gameObject, Time.deltaTime);

                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                {
                    HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
                    if (hgc.IsMine)
                    {
                        VRRig possibly = raycastHit.collider.GetComponentInParent<VRRig>();
                        if (possibly && possibly != GorillaTagger.Instance.offlineVRRig)
                        {
                            hgc.currentState = HalloweenGhostChaser.ChaseState.Grabbing;
                            hgc.grabTime = Time.time;
                            hgc.targetPlayer = NetworkSystem.Instance.LocalPlayer;
                        }
                    }
                    else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
                }
            }
        }
        public static void LucyChaseGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit raycastHit;
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward, out raycastHit);
                GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

                gameObject.transform.position = raycastHit.point;
                gameObject.GetComponent<Renderer>().material.color = Color.gray;
                GameObject.Destroy(gameObject.GetComponent<BoxCollider>());
                GameObject.Destroy(gameObject.GetComponent<Rigidbody>());
                GameObject.Destroy(gameObject.GetComponent<Collider>());
                GameObject.Destroy(gameObject, Time.deltaTime);

                /*  if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                  {
                      HalloweenGhostChaser hgc = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
                      if (hgc.IsMine)
                      {
                          VRRig possibly = raycastHit.collider.GetComponentInParent<VRRig>();
                          if (possibly && possibly != GorillaTagger.Instance.offlineVRRig)
                          {
                              hgc.currentState = HalloweenGhostChaser.ChaseState.Chasing;
                              hgc.targetPlayer = GetPlayerFromVRRig(possibly);
                          }
                      }
                      else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
                  } */
            }
        }
    }
}
          