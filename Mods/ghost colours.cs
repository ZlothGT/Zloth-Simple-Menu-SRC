using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class ghost_colours
    {
        public static void BlackGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.black; 
            }
        }
        public static void BlueGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.blue;
            }
        }
        public static void GrayGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.gray;
            }
        }
        public static void RedGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.red;
            }
        }
        public static void MagentaGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.magenta;
            }
        }
        public static void GreenGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.green;
            }
        }
        public static void YellowGhost()
        {
            foreach (HalloweenGhostChaser wg in GameObject.FindObjectsOfType<HalloweenGhostChaser>())
            {
                wg.defaultColor = Color.yellow;
            }
        }
    }
}
