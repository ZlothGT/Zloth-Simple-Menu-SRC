/*
using GorillaLocomotion.Gameplay;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;


namespace Zloths_Simple_Menu.Mods
{
    internal class broom_mods
    {
        public static void FastBrooms()
        {
            NoncontrollableBroomstick[] brooms = GetBroomSticks();
            foreach (NoncontrollableBroomstick broom in brooms)
            {
                broom.duration = 10f;
            }
        }

        public static void SlowBrooms()
        {
            NoncontrollableBroomstick[] brooms = GetBroomsticks();
            foreach (NoncontrollableBroomstick broom in brooms)
            {
                broom.duration = 60f;
            }
        }

        public static void SpazBrooms()
        {
            NoncontrollableBroomstick[] brooms = GetBroomsticks();
            foreach (NoncontrollableBroomstick broom in brooms)
            {
                Traverse.Create(broom).Field("progress").SetValue(UnityEngine.Random.Range(0f, 1f));
            }
        }

        public static void FixBroomSpeed()
        {
            NoncontrollableBroomstick[] brooms = GetBroomsticks();
            foreach (NoncontrollableBroomstick broom in brooms)
            {
                broom.duration = 30f;
            }
        }
    }
}
*/