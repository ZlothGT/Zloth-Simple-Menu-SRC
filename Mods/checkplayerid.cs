using Photon.Pun;
using System;
using System.IO;
using UnityEngine;

namespace Zloths_Simple_Menu.Mods
{
    internal class SavePlayerID
    {
        public static void SaveID()
        {
            string playerId = PhotonNetwork.LocalPlayer.UserId;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "PlayerID.txt");

            try
            {
                File.WriteAllText(filePath, $"Player ID: {playerId}");
                Debug.Log($"Player ID '{playerId}' saved to {filePath}");
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to write Player ID to file: {e.Message}");
            }
        }
    }
}
