using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Zloths_Simple_Menu.Mods
{
    internal class customboards
    {
        public static void customboardsON()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/motdtext").GetComponent<Text>().text = "Zloths Message of the menu version:";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/motd (1)").GetComponent<Text>().text = "Menu is currently in beta so yh, i will put more stuff here once the menu is officially released.";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/COC Text").GetComponent<Text>().text = "All of my mods are UND at the moment, this menu will be updated monthly as a minimum. Have fun using my mods! ";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/CodeOfConduct").GetComponent<Text>().text = "TYSM FOR USING ZLOTHS SIMPLE MENU <3";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/StaticUnlit/motdscreen").GetComponent<Renderer>().material.color = Color.blue; // <---- The color you want the motd screen to be (Defualt is green)
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/CodeOfConduct_Group/StaticUnlit/screen").GetComponent<Renderer>().material.color = Color.gray; // <---- The color you want the COC screen to be (Default is green)
            GameObject.Find("wallmonitorcanyon").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("wallmonitorcosmetics").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("wallmonitorcave").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("wallmonitorforest").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("wallmonitorskyjungle").GetComponent<Renderer>().material.color = Color.black;
        }


        public static void customboardsOFF()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/motdtext").GetComponent<Text>().text = "THE BAYOU IS HERE! EXPLORE THE MURKY WATER, BOUNCY LILY PADS, AND THE CREEPY MANSION. DON'T FORGET TO CHECK OUT THE MONKES WILD BUNDLE FOR SOME SWAMP ESSENTIALS!";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/motd (1)").GetComponent<Text>().text = "MESSAGE OF THE DAY";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/COC Text").GetComponent<Text>().text = "-NO RACISM, SEXISM, HOMOPHOBIA, TRANSPHOBIA, OR OTHER BIGOTRY\r\n-NO CHEATS OR MODS\r\n-DO NOT HARASS OTHER PLAYERS OR INTENTIONALLY MAKE THEM UNCOMFORTABLE\r\n-DO NOT TROLL OR GRIEF LOBBIES BY BEING UNCATCHABLE OR BY ESCAPING THE MAP. TRY TO MAKE SURE EVERYONE IS HAVING FUN\r\n-IF SOMEONE IS BREAKING THIS CODE, PLEASE REPORT THEM\r\n-PLEASE BE NICE GORILLAS AND HAVE A GOOD TIME";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/CodeOfConduct").GetComponent<Text>().text = "GORILLA CODE OF CONDUCT";
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/StaticUnlit/motdscreen").GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/CodeOfConduct_Group/StaticUnlit/screen").GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("wallmonitorcanyon").GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("wallmonitorcosmetics").GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("wallmonitorcave").GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("wallmonitorforest").GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("wallmonitorskyjungle").GetComponent<Renderer>().material.color = Color.green;
        }


    }
}